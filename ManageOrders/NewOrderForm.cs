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

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (cmbTables.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a table.");
                return;
            }

            if (dgvOrderItems.Rows.Count == 0)
            {
                MessageBox.Show("Order cannot be empty.");
                return;
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

            string selected = cmbItems.SelectedItem.ToString();

            string itemName = selected.Split('-')[0].Trim();
            decimal unitPrice = decimal.Parse(selected.Split('€')[1].Trim());

            int qty = (int)numQty.Value;

            if (qty <= 0)
            {
                MessageBox.Show("Quantity must be at least 1.");
                return;
            }

            decimal subtotal = qty * unitPrice;

            dgvOrderItems.Rows.Add(itemName, unitPrice.ToString("F2"), qty, subtotal.ToString("F2"));
            Validation.UpdateTotal(dgvOrderItems, lblTotal);

            cmbItems.SelectedIndex = -1;
            numQty.Value = numQty.Minimum;
        }

        private void cmbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvOrderItems.Rows.Clear();
            lblTotal.Text = "€0.00";
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
