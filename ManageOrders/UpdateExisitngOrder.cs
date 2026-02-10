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
            LoadMenuItems();
            dgvOrderItems.ClearSelection();
        }

        private void cmdOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvOrderItems.Rows.Clear();

            if (cmbOrders.SelectedIndex == 0)
            {
                dgvOrderItems.Rows.Add("Lasagna", "8.50", 2, "17.00");
                dgvOrderItems.Rows.Add("Lasagna", "11.00", 1, "11.00");
            }
            else if (cmbOrders.SelectedIndex == 1)
            {
                dgvOrderItems.Rows.Add("Lasagna", "9.30", 3, "27.90");
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




        private void lblQty_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalText_Click(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void dgvOrderItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


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

        private void cmbItems_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        public void LoadMenuItems()
        {
            cmbItems.Items.Clear();
            List<MenuItem> menuItems = MenuItem.GetMenuItems();

            foreach (MenuItem menuItem in menuItems)
            {
                cmbItems.Items.Add(menuItem);

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

            dgvOrderItems.Rows.Add(itemName, unitPrice.ToString("F2"), qty, subtotal.ToString("F2"));

            Validation.UpdateTotal(dgvOrderItems, lblTotal);
        }
    }
}
