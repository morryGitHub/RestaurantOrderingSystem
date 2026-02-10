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
    public partial class FrmUpdateOrder : Form
    {
        public FrmUpdateOrder()
        {
            InitializeComponent();
        }

        private void frmUpdateOrder_Load(object sender, EventArgs e)
        {
            FillActiveOrdersComboBox();
            FillMenuItemsComboBox();

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

        private void cmdOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvOrderItems.Rows.Clear();
            lblTotal.Text = "€0.00";

            if (cmbOrders.Text.Equals("Select the Order"))
            {
                btnCancel.Enabled = false;
                return;

            }

            btnCancel.Enabled = true;
            cmbOrders.Items.Remove("Select the Order");


            dgvOrderItems.Rows.Clear();

            Order order = cmbOrders.SelectedItem as Order;

            int orderID = order.OrderID;

            DataSet ds = OrderItem.GetMenuItemsFromOrder(orderID);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                string itemName = row["ItemName"].ToString();
                decimal unitPrice = Convert.ToDecimal(row["UnitPrice"]);
                int qty = Convert.ToInt32(row["Quantity"]);
                decimal subtotal = unitPrice * qty;
                int menuItemID = Convert.ToInt32(row["MenuItemID"]);


                dgvOrderItems.Rows.Add(
                    itemName,
                    unitPrice.ToString("F2"),
                    qty,
                    subtotal.ToString("F2"),
                    menuItemID
                );
            }




            Validation.UpdateTotal(dgvOrderItems, lblTotal);




        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (dgvOrderItems.Rows.Count == 0)
            {
                MessageBox.Show("Order must contain at least one item.");
                return;
            }

            MessageBox.Show(
                $"Order updated successfully!\nNew Total: {lblTotal.Text}",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            this.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order update cancelled.",
                    "Cancelled",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            this.Close();
        }




      
        private void lblTotalText_Click(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void dgvOrderItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOrderItems.Rows.Count == 0)
            {
                btnDeleteItem.Enabled = false;
                btnEditItem.Enabled = false;
            }
            else
            {
                btnDeleteItem.Enabled = true;
                btnEditItem.Enabled = true;
            }


            numQty.Value = 0;

            DataGridViewRow row = dgvOrderItems.SelectedRows[0];
            string name = row.Cells["ItemName"].Value.ToString();
            int qty = Convert.ToInt16(row.Cells["Qty"].Value);

            MenuItem selectedItem = null;
            foreach (MenuItem item in cmbItems.Items)
            {
                if (item.Name == name)
                {
                    selectedItem = item;
                    break;
                }
            }

            if (selectedItem != null)
            {
                cmbItems.SelectedItem = selectedItem;
            }
            else
            {
                throw new Exception("Error");
            }

            numQty.Value = qty;




        }

    

        private void UpdateButtonsState()
        {
            bool hasRows = dgvOrderItems.Rows.Count > 0;
            btnDeleteItem.Enabled = hasRows;
            btnEditItem.Enabled = hasRows;
        }


        private void cmbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbItems.Text.Equals("Select the Item"))
            {
                btnCancel.Enabled = false;
                return;

            }

            btnCancel.Enabled = true;
            cmbItems.Items.Remove("Select the Item");
        }

        private void numQty_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            if (cmbOrders.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a order.");
                return;
            }

            if (cmbItems.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a menu item.");
                return;
            }

            string selected = cmbItems.SelectedItem.ToString();
            string itemName = selected.Split('-')[0].Trim();
            decimal unitPrice = decimal.Parse(selected.Split('€')[1]);

            int qty = (int)numQty.Value;

            if (qty <= 0)
            {
                MessageBox.Show("Quantity must be at least 1.");
                return;
            }

            decimal subtotal = qty * unitPrice;

            //dgvOrderItems.Rows.Add(itemName, unitPrice.ToString("F2"), qty, subtotal.ToString("F2"));

            DataGridViewRow row = dgvOrderItems.SelectedRows[0];
            row.Cells["ItemName"].Value = itemName;
            row.Cells["UnitPrice"].Value = unitPrice.ToString("F2");
            row.Cells["Qty"].Value = qty;
            row.Cells["Subtotal"].Value = subtotal.ToString("F2");

            numQty.Value = numQty.Minimum;
            cmbItems.SelectedIndex = -1;

            Validation.UpdateTotal(dgvOrderItems, lblTotal);
        }

        public void FillMenuItemsComboBox()
        {
            cmbItems.Items.Clear();
            List<MenuItem> menuItems = MenuItem.GetMenuItems();


            cmbItems.Items.Add("Select the Item");
            cmbItems.SelectedIndex = 0;

            foreach (MenuItem menuItem in menuItems)
            {
                cmbItems.Items.Add(menuItem);

            }

        }

        public void FillActiveOrdersComboBox()
        {
            cmbOrders.Items.Clear();
            List<Order> orders = Order.LoadOrders();

            cmbOrders.Items.Add("Select the Order");
            cmbOrders.SelectedIndex = 0;

            foreach (Order order in orders)
            {
                cmbOrders.Items.Add(order);

            }

            

        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (dgvOrderItems.SelectedRows.Count == 0)
            {
                return;
            }

            int rowIndex = dgvOrderItems.SelectedRows[0].Index;

            var result = MessageBox.Show(
                "Remove this item?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                if (rowIndex >= 0)
                {
                    dgvOrderItems.Rows.RemoveAt(rowIndex);
                    Validation.UpdateTotal(dgvOrderItems, lblTotal);
                }

            }
        }

        private void btnAddButton_Click(object sender, EventArgs e)
        {
            if (cmbOrders.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a order.");
                return;
            }

            if (cmbItems.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a menu item.");
                return;
            }

            MenuItem menuItem = cmbItems.SelectedItem as MenuItem;

            string selected = cmbItems.SelectedItem.ToString();
            string itemName = selected.Split('-')[0].Trim();
            decimal unitPrice = decimal.Parse(selected.Split('€')[1]);

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

        }

        private void dgvOrderItems_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            UpdateButtonsState();

        }

        private void dgvOrderItems_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            UpdateButtonsState();

        }
    }
}
