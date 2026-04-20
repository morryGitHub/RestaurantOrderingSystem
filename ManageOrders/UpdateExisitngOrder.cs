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
        private int _selectedOrderId = -1;
        private int _menuItemID = -1;


        public FrmUpdateOrder()
        {
            InitializeComponent();
            UIStyleHelper.ApplyDarkTheme(dgvOrderItems);
            UIStyleHelper.ApplyPrimaryButtonStyle(btnConfirm);
            dgvOrderItems.DefaultCellStyle.SelectionBackColor = Color.LightBlue;


        }

        private void frmUpdateOrder_Load(object sender, EventArgs e)
        {
            FillActiveOrdersComboBox();
            FillMenuItemsComboBox();


        }

        private void cmdOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTotal.Text = "€0.00";

            if (cmbOrders.Text.Equals("Select the Order"))
            {
                btnCancel.Enabled = false;
                return;

            }

            btnCancel.Enabled = true;
            cmbOrders.Items.Remove("Select the Order");

            Order order = cmbOrders.SelectedItem as Order;

            _selectedOrderId = order.ID;

            DataSet dsActive = OrderItem.GetMenuItemsFromOrder(_selectedOrderId, "Active");

            foreach (DataRow row in dsActive.Tables[0].Rows)
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
            
            _selectedOrderId = -1;

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

            if (cmbOrders.SelectedIndex == -1 || _selectedOrderId == -1)
            {
                MessageBox.Show("Please select an order.");
                return;
            }

            MenuItem menuItem = cmbItems.SelectedItem as MenuItem;
            if (menuItem == null)
            {
                MessageBox.Show("Please select a menu item.");
                return;
            }

            int qty = (int)numQty.Value;
            if (qty <= 0)
            {
                MessageBox.Show("Quantity must be at least 1.");
                return;
            }

            string itemName = menuItem.Name;
            decimal unitPrice = menuItem.Price;
            _menuItemID = menuItem.ItemID;
            decimal subtotal = qty * unitPrice;


            OrderItem orderItem = new OrderItem(_selectedOrderId, _menuItemID, qty);
            try
            {
                orderItem.AddOrderItems(isEditMode: true);

                bool isRowExist = false;
                foreach (DataGridViewRow row in dgvOrderItems.Rows)
                {
                    if (row.Cells["MenuItemID"].Value != null &&
                        Convert.ToInt32(row.Cells["MenuItemID"].Value) == _menuItemID)
                    {
                        int currentQty = Convert.ToInt32(row.Cells["Qty"].Value);
                        int newQty = qty;

                        row.Cells["Qty"].Value = newQty;
                        row.Cells["Subtotal"].Value = (newQty * unitPrice).ToString("F2");

                        isRowExist = true;
                        break;
                    }
                }

                if (!isRowExist)
                {
                    dgvOrderItems.Rows.Add(itemName, unitPrice.ToString("F2"), qty, subtotal.ToString("F2"), _menuItemID);
                }

                Validation.UpdateTotal(dgvOrderItems, lblTotal);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save item to database: " + ex.Message);
            }
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

            DataGridViewRow row = dgvOrderItems.SelectedRows[0];
            _menuItemID = Convert.ToInt16(row.Cells["MenuItemID"].Value);

            OrderItem orderItem = new OrderItem(_selectedOrderId, _menuItemID);
            

            var result = MessageBox.Show(
                "Remove this item?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                if (rowIndex >= 0)
                {
                    try
                    {
                        orderItem.DeleteItemFromOrder();
                        dgvOrderItems.Rows.RemoveAt(rowIndex);
                        Validation.UpdateTotal(dgvOrderItems, lblTotal);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting item: " + ex.Message);
                    }

                }
            }

            _menuItemID = -1;
        }

        private void btnAddButton_Click(object sender, EventArgs e)
        {
            if (cmbOrders.SelectedIndex == -1 || _selectedOrderId == -1)
            {
                MessageBox.Show("Please select an order.");
                return;
            }

            MenuItem menuItem = cmbItems.SelectedItem as MenuItem;
            if (menuItem == null)
            {
                MessageBox.Show("Please select a menu item.");
                return;
            }

            int qty = (int)numQty.Value;
            if (qty <= 0)
            {
                MessageBox.Show("Quantity must be at least 1.");
                return;
            }

            string itemName = menuItem.Name;
            decimal unitPrice = menuItem.Price;
            _menuItemID = menuItem.ItemID;
            decimal subtotal = qty * unitPrice;

            OrderItem orderItem = new OrderItem(_selectedOrderId, _menuItemID, qty);
            try
            {
                orderItem.AddOrderItems();

                bool isRowExist = false;
                foreach (DataGridViewRow row in dgvOrderItems.Rows)
                {
                    if (row.Cells["MenuItemID"].Value != null &&
                        Convert.ToInt32(row.Cells["MenuItemID"].Value) == _menuItemID)
                    {
                        int currentQty = Convert.ToInt32(row.Cells["Qty"].Value);
                        int newQty = currentQty + qty;

                        row.Cells["Qty"].Value = newQty;
                        row.Cells["Subtotal"].Value = (newQty * unitPrice).ToString("F2");

                        isRowExist = true;
                        break;
                    }
                }

                if (!isRowExist)
                {
                    dgvOrderItems.Rows.Add(itemName, unitPrice.ToString("F2"), qty, subtotal.ToString("F2"), _menuItemID);
                }

                Validation.UpdateTotal(dgvOrderItems, lblTotal);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save item to database: " + ex.Message);
            }
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
