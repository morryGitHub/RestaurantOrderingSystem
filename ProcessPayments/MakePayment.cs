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
    public partial class FrmMakePayment : Form
    {
        public FrmMakePayment()
        {
            InitializeComponent();
            UIStyleHelper.ApplyDarkTheme(dgvOrderItems);
            UIStyleHelper.ApplyPrimaryButtonStyle(btnPay);
            UIStyleHelper.ApplyCancelButtonStyle(btnCancel);
        }


        private void BtnPay_Click(object sender, EventArgs e)
        {
            if (cmbOrders.SelectedItem.ToString() == "Select the Order")
            {
                MessageBox.Show("Please select an order.");
                return;
            }

            if (cmbMethod.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a payment method.");
                return;
            }

            try
            {
                decimal total = decimal.Parse(lblAmount.Text.Replace("€", ""));
                string orderName = cmbOrders.SelectedItem.ToString();
                string method = cmbMethod.SelectedItem.ToString();
                Order order = cmbOrders.SelectedItem as Order;


                Payment payment = new Payment(order, total, method, DateTime.Now.ToString("dd-MM-yyyy HH:mm"));
                payment.MakePayment();

                MessageBox.Show("Payment successful.\nOrder is now PAID.\nTable is now AVAILABLE.",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);



                FrmReceipt receipt = new FrmReceipt(orderName, method, total, dgvOrderItems);
                receipt.ShowDialog();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing payment: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BtnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No payment was processed.",
                    "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void FrmMakePayment_Load(object sender, EventArgs e)
        {

            this.BackColor = Color.White;

            lblTitle.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(30, 30, 30);

            lblAmount.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblAmount.ForeColor = Color.FromArgb(50, 50, 50);

            FillActiveOrdersComboBox();
            FillMethodType();
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

        private void FillMethodType()
        {
            cmbMethod.Items.Clear();
            cmbMethod.Items.Add("Card");
            cmbMethod.Items.Add("Cash");

        }


        private void CmbOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvOrderItems.Rows.Clear();
            lblAmount.Text = "€0.00";

            if (cmbOrders.Text.Equals("Select the Order"))
            {
                return;
            }

            btnCancel.Enabled = true;
            cmbOrders.Items.Remove("Select the Order");


            try
            {
                Order order = cmbOrders.SelectedItem as Order;
                OrderItem orderItem = new OrderItem(order);
                DataSet dsActive = orderItem.GetMenuItemsFromOrder();


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




                lblAmount.Text = $"€{Validation.GetTotalAmount(dgvOrderItems):F2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading order items: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
