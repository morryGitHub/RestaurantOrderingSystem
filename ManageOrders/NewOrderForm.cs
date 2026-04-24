using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantOrderingSystem
{
    public partial class FrmNewOrder : Form
    {
        internal int _tableId = -1;

        public FrmNewOrder()
        {
            InitializeComponent();
            UIStyleHelper.ApplyDarkTheme(dgvOrderItems);
            UIStyleHelper.ApplyPrimaryButtonStyle(btnAddItem);
            UIStyleHelper.ApplyPrimaryButtonStyle(btnConfirm);
            UIStyleHelper.ApplyCancelButtonStyle(btnExit);
        }

        internal FrmNewOrder(Table table)
        {
            InitializeComponent();
            _tableId = table.TableId;
            UIStyleHelper.ApplyDarkTheme(dgvOrderItems);
            UIStyleHelper.ApplyPrimaryButtonStyle(btnAddItem);
            UIStyleHelper.ApplyPrimaryButtonStyle(btnConfirm);
            UIStyleHelper.ApplyCancelButtonStyle(btnExit);
        }

        private void NewOrderForm_Load(object sender, EventArgs e)
        {
            LoadTables();

            if (_tableId != -1)
            {
                LoadBookedTable();
            }

            LoadMenuItems();


        }


        private void BtnConfirm_Click(object sender, EventArgs e)
        {

            if (!(cmbAvailableTables.SelectedItem is Table selectedTable))
            {
                MessageBox.Show("Please select a table from the list to continue.",
                                "Selection Required",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information); return;
            }

            if (dgvOrderItems.Rows.Count == 0)
            {
                MessageBox.Show("Your order is empty. Please add at least one item before proceeding.",
                                "Empty Order",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            btnConfirm.Enabled = dgvOrderItems.RowCount > 0;


            try
            {

                DateTime dateTime = DateTime.Now;
                decimal total = Convert.ToDecimal(lblTotal.Text.Split('€')[1]);

                Order order = new Order(selectedTable, dateTime, total);

                order.AddOrder();
                int newOrderID = OrderItem.GetLastOrderID();


                foreach (DataGridViewRow row in dgvOrderItems.Rows)
                {
                    if (row.IsNewRow) { continue; }
                    int menuItemID = Convert.ToInt32(row.Cells["MenuItemID"].Value);
                    int qty = Convert.ToInt32(row.Cells["Qty"].Value);
                    decimal _ = Convert.ToDecimal(row.Cells["UnitPrice"].Value);

                    OrderItem orderItem = new OrderItem(newOrderID, menuItemID, qty);
                    orderItem.AddOrderItems();
                }

                MessageBox.Show(
                        $"Order created successfully!\nTotal Amount: {lblTotal.Text}",
                         "Success",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Information
                    );

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"An error occurred while creating the order.\nError: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order creation cancelled.",
                           "Cancelled",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information);

            this.Close();
        }

        private void BtnAddItem_Click_1(object sender, EventArgs e)
        {
            if (!(cmbItems.SelectedItem is MenuItem menuItem))
            {
                MessageBox.Show("Please select a valid menu item from the list.",
                         "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string itemName = menuItem.Name;
            decimal unitPrice = menuItem.Price;
            int menuItemID = menuItem.ID;

            int qty = (int)numQty.Value;

            if (qty <= 0)
            {
                MessageBox.Show("Please enter a valid quantity (at least 1).",
                         "Invalid Quantity",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Warning);
                return;
            }

            decimal subtotal = qty * unitPrice;
            bool isRowExist = false;

            foreach (DataGridViewRow rows in dgvOrderItems.Rows)
            {
                if (rows.Cells["ItemName"].Value != null &&
                    rows.Cells["ItemName"].Value.ToString() == itemName)
                {
                    DataGridViewRow row = rows;
                    int currentQty = 0;
                    if (row.Cells["Qty"].Value != null)
                        currentQty = Convert.ToInt32(row.Cells["Qty"].Value);



                    row.Cells["Qty"].Value = currentQty + qty;
                    row.Cells["Subtotal"].Value = ((currentQty + qty) * unitPrice).ToString("F2");
                    isRowExist = true;
                    break;
                }
            }

            if (!isRowExist)
            {
                dgvOrderItems.Rows.Add(itemName, unitPrice.ToString("F2"), qty, subtotal.ToString("F2"), menuItemID);
            }

            lblTotal.Text = $"€{Validation.GetTotalAmount(dgvOrderItems):F2}";

            cmbItems.SelectedIndex = -1;
            numQty.Value = numQty.Minimum;

        }

        private void CmbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvOrderItems.Rows.Clear();
            lblTotal.Text = "€0.00";

            if (!(cmbAvailableTables.SelectedItem is Table))
            {
                return;
            }


            if (cmbAvailableTables.Items.Contains("-- Select the Table --"))
            {
                cmbAvailableTables.Items.Remove("-- Select the Table --");
            }
        }

        private void DgvOrderItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var result = MessageBox.Show(
                "Are you sure you want to remove this item from the order?",
                "Confirm Removal",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);



            if (result == DialogResult.Yes)
            {
                if (e.RowIndex >= 0)
                {
                    dgvOrderItems.Rows.RemoveAt(e.RowIndex);
                    lblTotal.Text = $"€{Validation.GetTotalAmount(dgvOrderItems):F2}";
                }

            }
        }

        private void LoadTables()
        {
            try
            {
                List<Table> tables = Table.GetAvailableTables();

                if (tables == null || tables.Count == 0)
                {
                    cmbAvailableTables.Items.Add("-- No Tables Available --");
                    cmbAvailableTables.SelectedIndex = 0;
                    cmbAvailableTables.Enabled = false;
                    return;
                }

                foreach (Table table in tables)
                {
                    cmbAvailableTables.Items.Add(table);
                }

                if (cmbAvailableTables.Items.Count == 0)
                {
                    cmbAvailableTables.Items.Add("-- No Tables Available --");
                    cmbAvailableTables.SelectedIndex = 0;
                    cmbAvailableTables.Enabled = false;
                }

                cmbAvailableTables.Items.Insert(0, "-- Select the Table --");
                cmbAvailableTables.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the tables:\n\n{ex.Message}",
                                "Database Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void LoadMenuItems()
        {

            try
            {
                cmbItems.Items.Clear();
                List<MenuItem> menuItems = MenuItem.GetMenuItems();

                if (menuItems.Count == 0)
                {
                    cmbItems.Items.Add("-- No Items Available --");
                    cmbItems.SelectedIndex = 0;
                    cmbItems.Enabled = false;
                    return;
                }

                foreach (MenuItem item in menuItems)
                {
                    cmbItems.Items.Add(item);
                }

                cmbItems.Items.Insert(0, "-- Select the Item --");
                cmbItems.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the menu items:\n\n{ex.Message}",
                                "Loading Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }



        private void CmbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(cmbItems.SelectedItem is MenuItem))
            {
                btnAddItem.Enabled = false;
                return;
            }


            btnAddItem.Enabled = true;


            if (cmbItems.Items.Contains("-- Select the Item --"))
            {
                cmbItems.Items.Remove("-- Select the Item --");
            }

        }

        private void LoadBookedTable()
        {

            try
            {
                cmbAvailableTables.Items.Clear();
                Table bookedTable = new Table { TableId = _tableId }.GetTable();
                cmbAvailableTables.Items.Add(bookedTable);
                cmbAvailableTables.SelectedIndex = 0;
                cmbAvailableTables.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the booked tables:\n\n{ex.Message}",
                                "Database Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void BackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
