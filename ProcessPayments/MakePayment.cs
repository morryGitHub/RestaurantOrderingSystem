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
            DataGridViewHelper.ApplyDarkTheme(dgvOrderItems);

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnPay_Click(object sender, EventArgs e)
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


        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payment cancelled.", "Cancelled", MessageBoxButtons.OK);
            this.Close();
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
            var normal = new Font("Segoe UI", 10, FontStyle.Regular);

            this.BackColor = Color.White;

            // TITLE
            lblTitle.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(30, 30, 30);

          

            // BUTTONS
            StyleButton(btnPay);
            StyleButton(btnCancel, isSecondary: true);

            // LABEL TOTAL
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

        private void dgvOrderItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvOrderItems.Rows.Clear();
            lblAmount.Text = "€0.00";

            if (cmbOrders.Text.Equals("Select the Order"))
            {
                return;
            }

            btnCancel.Enabled = true;
            cmbOrders.Items.Remove("Select the Order");

            Order order = cmbOrders.SelectedItem as Order;
            DataSet dsActive = OrderItem.GetMenuItemsFromOrder(order.ID, "Active");


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




            Validation.UpdateTotal(dgvOrderItems, lblAmount);
        }

        private void StyleButton(Button btn, bool isSecondary = false)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;

            if (!isSecondary)
            {
                btn.BackColor = Color.FromArgb(0, 120, 215); // синий
                btn.ForeColor = Color.White;
            }
            else
            {
                btn.BackColor = Color.LightGray;
                btn.ForeColor = Color.Black;
            }
        }
    }


}
