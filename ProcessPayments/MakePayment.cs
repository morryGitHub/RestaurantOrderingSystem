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
    public partial class FrmMakePayment : Form
    {
        public FrmMakePayment()
        {
            InitializeComponent();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (cmbOrders.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an order.");
                return;
            }

            if (cmbMethod.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a payment method.");
                return;
            }

            MessageBox.Show("Payment successful.\nOrder is now PAID.\nTable is now AVAILABLE.",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            decimal total = decimal.Parse(lblTotal.Text.Replace("€", ""));
            string orderName = cmbOrders.SelectedItem.ToString();
            string method = cmbMethod.SelectedItem.ToString();

            FrmReceipt receipt = new FrmReceipt(orderName, method, total, dgvOrderItems);
            receipt.ShowDialog();

            this.Close();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payment cancelled.", "Cancelled", MessageBoxButtons.OK);
            this.Close();
        }

        private void cmbOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvOrderItems.Rows.Clear();

            if (cmbOrders.SelectedIndex == 0)
            {
                dgvOrderItems.Rows.Add("Pizza", "11.00", 2, "22.00");
                dgvOrderItems.Rows.Add("Water", "2.00", 1, "2.00");
                lblTotal.Text = "€24.00";
                lblAmount.Text = "€24.00";
            }
            else
            {
                dgvOrderItems.Rows.Add("Steak", "18.00", 1, "18.00");
                dgvOrderItems.Rows.Add("Cola", "3.50", 2, "3.50");
                lblTotal.Text = "€25.00";
                lblAmount.Text = "€25.00";

            }
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalText_Click(object sender, EventArgs e)
        {

        }


        private void cmbMethod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblSelectItems_Click(object sender, EventArgs e)
        {

        }

        private void frmMakePayment_Load(object sender, EventArgs e)
        {
            dgvOrderItems.ClearSelection();

        }
    }
}
