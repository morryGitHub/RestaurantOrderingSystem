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

        private int _newMenuItemID = -1;
        private int _oldMenuItemID = -1;
        private int _selectedOrderId = -1;

        public FrmUpdateOrder()
        {
            InitializeComponent();
            UIStyleHelper.ApplyDarkTheme(dgvOrderItems);
            UIStyleHelper.ApplyPrimaryButtonStyle(btnConfirm);
            UIStyleHelper.ApplyCancelButtonStyle(btnCancel);

            dgvOrderItems.DefaultCellStyle.SelectionBackColor = Color.LightBlue;


        }

        private void FrmUpdateOrder_Load(object sender, EventArgs e)
        {
            FillActiveOrdersComboBox();
            FillMenuItemsComboBox();


        }

        private void CmdOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvOrderItems.Rows.Clear();
            decimal total = 0.00m;
            lblTotal.Text = $"€{total:F2}";

            if (!(cmbOrders.SelectedItem is Order selectedOrder))
            {
                btnConfirm.Enabled = false;
                btnEditItem.Enabled = false;
                btnAddItem.Enabled = false;
                return;
            }

            btnConfirm.Enabled = true;
            btnEditItem.Enabled = true;
            btnAddItem.Enabled = true;

            if (cmbOrders.Items.Contains("-- Select the Order --"))
            {
                cmbOrders.Items.Remove("-- Select the Order --");
            }

            try
            {
                _selectedOrderId = selectedOrder.Id;
                OrderItem orderItem = new OrderItem(_selectedOrderId);
                DataSet dsActive = orderItem.GetMenuItemsFromOrder("Active");

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

                total = Validation.GetTotalAmount(dgvOrderItems);
                lblTotal.Text = $"€{total:F2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load the items for this order:\n\n{ex.Message}",
                                "Loading Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }


        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (dgvOrderItems.Rows.Count == 0)
            {
                MessageBox.Show("Your order is empty...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
        
                OrderItem tempCleaner = new OrderItem(_selectedOrderId);
                tempCleaner.DeleteAllItemsFromOrder(); 

                foreach (DataGridViewRow row in dgvOrderItems.Rows)
                {
                    if (row.IsNewRow) continue;

                    int menuItemID = Convert.ToInt32(row.Cells["MenuItemID"].Value);
                    int qty = Convert.ToInt32(row.Cells["Qty"].Value);

                    OrderItem itemToSave = new OrderItem(_selectedOrderId, menuItemID, qty);
                    itemToSave.AddOrderItems(); 
                }

                MessageBox.Show("Order updated successfully in database!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving order: {ex.Message}", "Database Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order update cancelled.",
                    "Cancelled",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            this.Close();
        }


        private void DgvOrderItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvOrderItems.Rows[e.RowIndex];

                string name = row.Cells["ItemName"].Value.ToString();
                string qty = row.Cells["Qty"].Value.ToString();
                int menuItemID = Convert.ToInt32(row.Cells["MenuItemID"].Value);

                cmbItems.SelectedItem = cmbItems.Items
                    .OfType<MenuItem>()
                    .FirstOrDefault(item => item.ID == menuItemID);

                numQty.Value = Convert.ToDecimal(qty);
            }
        }



        private void UpdateButtonsState()
        {
            bool hasRows = dgvOrderItems.Rows.Count > 0;
            btnDeleteItem.Enabled = hasRows;
            btnEditItem.Enabled = hasRows;
        }


        private void CmbItems_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (!(cmbItems.SelectedItem is MenuItem) || !(cmbOrders.SelectedItem is Order))
            {
                btnAddItem.Enabled = false;
                btnDeleteItem.Enabled = false;
                btnEditItem.Enabled = false;
                return;
            }

            btnAddItem.Enabled = true;
            btnDeleteItem.Enabled = true;
            btnEditItem.Enabled = true;

            if (cmbItems.Items.Contains("-- Select the Item --"))
            {
                cmbItems.Items.Remove("-- Select the Item --");
            }

            numQty.Value = 1;
        }


        private void BtnEditItem_Click(object sender, EventArgs e)
        {
            if (!(cmbOrders.SelectedItem is Order) || dgvOrderItems.RowCount == 0)
            {
                MessageBox.Show("Please select an order from the list to continue.",
                                "Selection Required",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information); return;
            }

            if (!(cmbItems.SelectedItem is MenuItem menuItem) || dgvOrderItems.RowCount == 0)
            {
                MessageBox.Show("Please select a menu item to add it to the order.",
                                "Selection Required",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information); return;
            }

            int qty = (int)numQty.Value;
            if (qty <= 0)
            {
                MessageBox.Show("Quantity must be at least 1. Please enter a valid amount.",
                                "Invalid Quantity",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning); return;
            }

            _newMenuItemID = menuItem.ID;
            string itemName = menuItem.Name;
            decimal unitPrice = menuItem.Price;
            decimal subtotal = qty * unitPrice;


            try
            {
                //OrderItem orderItem = new OrderItem(_selectedOrderId, _newMenuItemID, qty);
                //orderItem.AddOrderItems(isEditMode: true);

                btnCancel.Enabled = false;
                cmbOrders.Enabled = false;

                bool isRowExist = false;
                foreach (DataGridViewRow row in dgvOrderItems.Rows)
                {
                    if (row.Cells["MenuItemID"].Value != null &&
                        Convert.ToInt32(row.Cells["MenuItemID"].Value) == _newMenuItemID)
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
                    if (dgvOrderItems.SelectedRows.Count > 0)
                    {
                        DataGridViewRow row = dgvOrderItems.SelectedRows[0];
                        _oldMenuItemID = Convert.ToInt32(row.Cells["MenuItemID"].Value);

                        row.Cells["ItemName"].Value = itemName;
                        row.Cells["UnitPrice"].Value = unitPrice.ToString("F2");
                        row.Cells["Qty"].Value = qty;
                        row.Cells["Subtotal"].Value = subtotal.ToString("F2");
                        row.Cells["MenuItemID"].Value = _newMenuItemID;

                        OrderItem deleteOrderItem = new OrderItem(_selectedOrderId, _oldMenuItemID);
                        deleteOrderItem.DeleteItemFromOrder();

                    }
                    else
                    {
                        dgvOrderItems.Rows.Add(itemName, unitPrice.ToString("F2"), qty, subtotal.ToString("F2"), _newMenuItemID);
                    }
                }


                lblTotal.Text = $"€{Validation.GetTotalAmount(dgvOrderItems):F2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the item to the database:\n\n{ex.Message}",
                                "Database Save Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        public void FillMenuItemsComboBox()
        {
            try
            {
                cmbItems.Items.Clear();
                List<MenuItem> menuItems = MenuItem.GetMenuItems();

                foreach (MenuItem menuItem in menuItems)
                {
                    cmbItems.Items.Add(menuItem);

                }

                if (cmbItems.Items.Count == 0)
                {
                    cmbItems.Items.Add("-- No Menu Items --");
                    cmbOrders.SelectedIndex = 0;
                    cmbOrders.Enabled = false;
                    return;
                }

                cmbItems.Items.Insert(0, "-- Select the Item --");
                cmbItems.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load the menu items from the database:\n\n{ex.Message}",
                                "Loading Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        public void FillActiveOrdersComboBox()
        {
            cmbOrders.Items.Clear();
            List<Order> orders = Order.LoadOrders();


            foreach (Order order in orders)
            {
                cmbOrders.Items.Add(order);

            }

            if (cmbOrders.Items.Count == 0)
            {
                cmbOrders.Items.Add("-- No Active Orders --");
                cmbOrders.SelectedIndex = 0;
                cmbOrders.Enabled = false;
                return;
            }

            cmbOrders.Items.Insert(0, "-- Select the Order --");
            cmbOrders.SelectedIndex = 0;

        }

        private void BtnDeleteItem_Click(object sender, EventArgs e)
        {
            if (dgvOrderItems.SelectedRows.Count == 0)
            {
                return;
            }

            int rowIndex = dgvOrderItems.SelectedRows[0].Index;

            DataGridViewRow row = dgvOrderItems.SelectedRows[0];
            _newMenuItemID = Convert.ToInt16(row.Cells["MenuItemID"].Value);

            //OrderItem orderItem = new OrderItem(_selectedOrderId, _newMenuItemID);


            var result = MessageBox.Show(
                "Are you sure you want to remove this item from the order?",
                "Confirm Removal",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                if (rowIndex >= 0)
                {
                    try
                    {
                        //orderItem.DeleteItemFromOrder();
                        cmbOrders.Enabled = false;
                        btnCancel.Enabled = false;

                        dgvOrderItems.Rows.RemoveAt(rowIndex);
                        lblTotal.Text = $"€{Validation.GetTotalAmount(dgvOrderItems):F2}";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed to remove the item from the database:\n\n{ex.Message}",
                                                    "Deletion Error",
                                                    MessageBoxButtons.OK,
                                                    MessageBoxIcon.Error);
                    }

                }
            }

            _newMenuItemID = -1;
        }

        private void BtnAddButton_Click(object sender, EventArgs e)
        {
            if (!(cmbOrders.SelectedItem is Order))
            {
                MessageBox.Show("Please select an order from the list before proceeding.",
                                "Selection Required",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            if (!(cmbItems.SelectedItem is MenuItem menuItem))
            {
                MessageBox.Show("Please select a menu item from the list to add it to your order.",
                                "Selection Required",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            int qty = (int)numQty.Value;
            if (qty <= 0)
            {
                MessageBox.Show("Quantity must be at least 1. Please enter a valid amount.",
                                "Invalid Quantity",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            string itemName = menuItem.Name;
            decimal unitPrice = menuItem.Price;
            _newMenuItemID = menuItem.ID;
            decimal subtotal = qty * unitPrice;

            //OrderItem orderItem = new OrderItem(_selectedOrderId, _newMenuItemID, qty);
            try
            {
                //orderItem.AddOrderItems();
                cmbOrders.Enabled = false;
                btnCancel.Enabled = false;


                bool isRowExist = false;

                foreach (DataGridViewRow row in dgvOrderItems.Rows)
                {
                    if (row.Cells["MenuItemID"].Value != null &&
                        Convert.ToInt32(row.Cells["MenuItemID"].Value) == _newMenuItemID)
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
                    dgvOrderItems.Rows.Add(itemName, unitPrice.ToString("F2"), qty, subtotal.ToString("F2"), _newMenuItemID);
                }

                lblTotal.Text = $"€{Validation.GetTotalAmount(dgvOrderItems):F2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the item to the database:\n\n{ex.Message}",
                                "Database Save Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void DgvOrderItems_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            UpdateButtonsState();

        }

        private void DgvOrderItems_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            UpdateButtonsState();

        }

        private void BackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
