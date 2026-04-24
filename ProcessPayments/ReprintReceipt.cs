using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantOrderingSystem
{
    public partial class FrmReprintReceipt : Form
    {
        public FrmReprintReceipt()
        {
            InitializeComponent();
            UIStyleHelper.ApplyDarkTheme(dgvOrderDetails);
            UIStyleHelper.ApplyPrimaryButtonStyle(btnReprint);
            UIStyleHelper.ApplyCancelButtonStyle(btnCancel);


        }




        private void ReprintReceipt_Load(object sender, EventArgs e)
        {
            FillPaidPaymentsComboBox();
        }


        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void BtnRefund_Click(object sender, EventArgs e)
        {
            if (!(cmbOrders.SelectedItem is Order order))
            {
                MessageBox.Show("It looks like no order is selected. Just click on the order you'd like to reprint from the list above.",
                                "No Selection Made", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            try
            {
                string orderName = order.ToString();

                string paymentMethod = Payment.GetPaymentMethodByOrder(order.Id) ?? "Unspecified";

                OrderItem orderItem = new OrderItem(order.Id);
                DataSet dsItems = orderItem.GetMenuItemsFromOrder("Completed");
                decimal total = 0;
                foreach (DataRow row in dsItems.Tables[0].Rows)
                {
                    decimal unitPrice = Convert.ToDecimal(row["UnitPrice"]);
                    int qty = Convert.ToInt32(row["Quantity"]);
                    total += unitPrice * qty;
                }

                FrmReceipt receipt = new FrmReceipt(orderName, paymentMethod, total, dgvOrderDetails);
                receipt.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while reprinting the receipt:\n\n{ex.Message}",
                                "Reprinting Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }



        public void FillPaidPaymentsComboBox()
        {
            List<Order> orders = Payment.LoadPaidOrders();

            cmbOrders.Items.Clear();

            foreach (Order order in orders)
            {
                cmbOrders.Items.Add(order);
            }


            if (cmbOrders.Items.Count == 0)
            {
                cmbOrders.Items.Insert(0, "-- No Paid Orders --");
                cmbOrders.SelectedIndex = 0;
                cmbOrders.Enabled = false;
            }

            cmbOrders.Items.Insert(0, "-- Select the Order --");
            cmbOrders.SelectedIndex = 0;


        }

        private void CmbOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvOrderDetails.Rows.Clear();
            lblTotal.Text = "€0.00";

            if (!(cmbOrders.SelectedItem is Order selectedOrder))
            {
                btnReprint.Enabled = false;
                return;
            }

            btnReprint.Enabled = true;


            if (!cmbOrders.Items.Contains("-- Select the Order --"))
            {
                cmbOrders.Items.Insert(0, "-- Select the Order --");
            }

            try
            {
                OrderItem orderItem = new OrderItem(selectedOrder.Id);
                DataSet dsCompleted = orderItem.GetMenuItemsFromOrder("Completed");

                foreach (DataRow row in dsCompleted.Tables[0].Rows)
                {
                    string itemName = row["ItemName"].ToString();
                    decimal unitPrice = Convert.ToDecimal(row["UnitPrice"]);
                    int qty = Convert.ToInt32(row["Quantity"]);
                    decimal subtotal = unitPrice * qty;
                    int menuItemID = Convert.ToInt32(row["MenuItemID"]);


                    dgvOrderDetails.Rows.Add(
                        itemName,
                        unitPrice.ToString("F2"),
                        qty,
                        subtotal.ToString("F2"),
                        menuItemID
                    );
                }

                lblTotal.Text = $"€{Validation.GetTotalAmount(dgvOrderDetails):F2}";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the order details from the database:\n\n{ex.Message}",
                                "Loading Error",
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
