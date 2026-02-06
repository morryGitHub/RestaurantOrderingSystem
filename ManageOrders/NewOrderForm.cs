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
    public partial class frmNewOrder : Form
    {
        public frmNewOrder()
        {
            InitializeComponent();
        }

        private void NewOrderForm_Load(object sender, EventArgs e)
        {
            LoadTables();
            LoadMenuItems();

            var normal = new Font("Segoe UI", 12, FontStyle.Regular);
      
            dgvOrderItems.Font = normal;
            dgvOrderItems.DefaultCellStyle.Font = normal;
            dgvOrderItems.RowsDefaultCellStyle.Font = normal;
            dgvOrderItems.AlternatingRowsDefaultCellStyle.Font = normal;

            dgvOrderItems.ColumnHeadersDefaultCellStyle.Font = normal;
            dgvOrderItems.RowHeadersDefaultCellStyle.Font = normal;

            dgvOrderItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrderItems.ReadOnly = true;
            dgvOrderItems.MultiSelect = false;

            dgvOrderItems.ClearSelection();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (cmbAvailableTables.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a table.");
                return;
            }

            if (dgvOrderItems.Rows.Count == 0)
            {
                MessageBox.Show("Order cannot be empty.");
                return;
            }

            var selectedTable = cmbAvailableTables.SelectedItem as Table;
            int tableID = Convert.ToInt16(selectedTable.TableId);
            DateTime dateTime = DateTime.Now;
            decimal total = Convert.ToDecimal(lblTotal.Text.Split('€')[1]);

            Order order = new Order(tableID, dateTime, total);

            order.AddOrder();
            int newOrderID = OrderItem.GetLastOrderID();


            foreach (DataGridViewRow row in dgvOrderItems.Rows)
            {
                if (row.IsNewRow) { continue; }
                int menuItemID = Convert.ToInt32(row.Cells["MenuItemID"].Value);
                int qty = Convert.ToInt32(row.Cells["Qty"].Value);
                decimal price = Convert.ToDecimal(row.Cells["UnitPrice"].Value);

                OrderItem orderItem = new OrderItem(newOrderID, menuItemID, qty, price);
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order creation cancelled.",
                           "Cancelled",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information);

            this.Close();
        }

        private void btnAddItem_Click_1(object sender, EventArgs e)
        {
            if (cmbItems.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a menu item first.");
                return;
            }

            MenuItem menuItem = cmbItems.SelectedItem as MenuItem;

            string itemName = menuItem.Name;
            decimal unitPrice = menuItem.Price;
            int menuItemID = menuItem.ItemID;

            int qty = (int)numQty.Value;

            if (qty <= 0)
            {
                MessageBox.Show("Quantity must be at least 1.");
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

            Validation.UpdateTotal(dgvOrderItems, lblTotal);

            cmbItems.SelectedIndex = -1;
            numQty.Value = numQty.Minimum;
        }

        private void cmbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvOrderItems.Rows.Clear();
            lblTotal.Text = "€0.00";

            if (cmbAvailableTables.Text.Equals("Select the Table"))
            {
                btnAddItem.Enabled = false;
                btnConfirm.Enabled = false;
                return;

            }

            btnAddItem.Enabled = false;
            btnConfirm.Enabled = false;
            cmbAvailableTables.Items.Remove("Select the Table");
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void dgvOrderItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var result = MessageBox.Show(
            "Remove this item?",
            "Confirm",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

            

            if (result == DialogResult.Yes)
            {
                if (e.RowIndex >= 0)
                {
                    dgvOrderItems.Rows.RemoveAt(e.RowIndex);
                    Validation.UpdateTotal(dgvOrderItems, lblTotal);
                }

            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void LoadTables()
        {
            cmbAvailableTables.Items.Clear();

            List<Table> tables = Table.GetAvailableTables();

            if (tables.Count == 0)
            {
                cmbAvailableTables.Items.Add("No Tables Available");
                cmbAvailableTables.SelectedIndex = 0;
                cmbAvailableTables.Enabled = false;
                return;
            }

            cmbAvailableTables.Items.Add("Select the Table");
            cmbAvailableTables.SelectedIndex = 0;

            foreach (Table table in tables)
            {
                cmbAvailableTables.Items.Add(table);
            }
        }

        private void LoadMenuItems()
        {
            cmbItems.Items.Clear();
            List<MenuItem> menuItems = MenuItem.GetMenuItems();

            if (menuItems.Count == 0)
            {
                cmbItems.Items.Add("No Items Available");
                cmbItems.SelectedIndex = 0;
                cmbItems.Enabled = false;
                return;
            }

            cmbItems.Items.Add("Select the Item");
            cmbItems.SelectedIndex = 0;

            foreach (MenuItem item in menuItems)
            {
                cmbItems.Items.Add(item);
            }
        }

        private void cmbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbItems.SelectedIndex == 0)
            {
                btnAddItem.Enabled = false;
                btnConfirm.Enabled = false;
                return;

            }

            btnAddItem.Enabled = true;
            btnConfirm.Enabled = true;
            cmbItems.Items.Remove("Select the Item");  // removes the placeholder

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
