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
        }




        private void ReprintReceipt_Load(object sender, EventArgs e)
        {
            // Define standard font
            var normal = new Font("Segoe UI", 10, FontStyle.Regular);

            // 1. FORM STYLE
            this.BackColor = Color.White;

            // 2. TITLE STYLE (Assuming lblTitle exists)
            lblTitle.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(30, 30, 30);

            // 3. DATAGRID STYLE (dgvOrderDetails)
            dgvOrderDetails.BorderStyle = BorderStyle.None;
            dgvOrderDetails.EnableHeadersVisualStyles = false;

            // Header Styles (Dark Gray background, White text)
            dgvOrderDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48);
            dgvOrderDetails.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvOrderDetails.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvOrderDetails.ColumnHeadersHeight = 35;

            // Body Styles
            dgvOrderDetails.DefaultCellStyle.Font = normal;

            // Selection Style (Invisible selection to match Revenue form)
            dgvOrderDetails.DefaultCellStyle.SelectionBackColor = dgvOrderDetails.DefaultCellStyle.BackColor;
            dgvOrderDetails.DefaultCellStyle.SelectionForeColor = dgvOrderDetails.DefaultCellStyle.ForeColor;

            // Header Selection (Prevents blue highlight when clicking headers)
            dgvOrderDetails.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvOrderDetails.ColumnHeadersDefaultCellStyle.BackColor;
            dgvOrderDetails.ColumnHeadersDefaultCellStyle.SelectionForeColor = dgvOrderDetails.ColumnHeadersDefaultCellStyle.ForeColor;

            dgvOrderDetails.RowHeadersVisible = false;
            dgvOrderDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrderDetails.AllowUserToAddRows = false;
            dgvOrderDetails.ReadOnly = true;
            dgvOrderDetails.MultiSelect = false;

            // 4. BUTTONS STYLE
            StyleButton(btnReprint);                 // Primary Blue (Used for Reprint)
            StyleButton(btnCancel, isSecondary: true); // Secondary Gray

            // 5. TOTAL LABEL STYLE
            lblTotal.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(50, 50, 50);

            // 6. DATA LOADING
            dgvOrderDetails.ClearSelection();
            FillPaidPaymentsComboBox();
        }

        // Helper method to maintain consistent button design across all forms
        private void StyleButton(Button btn, bool isSecondary = false)
        {
            if (btn == null) return;

            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            if (!isSecondary)
            {
                // Primary Blue Style
                btn.BackColor = Color.FromArgb(0, 120, 215);
                btn.ForeColor = Color.White;
            }
            else
            {
                // Secondary Gray Style
                btn.BackColor = Color.LightGray;
                btn.ForeColor = Color.Black;
            }
        }

        private void dgvPayments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

      

    

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnRefund_Click(object sender, EventArgs e)
        {
            Order order = cmbOrders.SelectedItem as Order;
            if (order == null) return;

            string orderName = $"Table {order.Table.TableNumber} — Order #{order.ID}";

            string paymentMethod = Payment.GetPaymentMethodByOrder(order.ID) ?? "Unspecified";

            DataSet dsItems = OrderItem.GetMenuItemsFromOrder(order.ID, "Completed");
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



        public void FillPaidPaymentsComboBox()
        {
            List<Order> orders = Payment.LoadPaidOrders();

            cmbOrders.Items.Clear();

            foreach (Order order in orders)
            {
                cmbOrders.Items.Add(order);
            }


        }

        private void cmbOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvOrderDetails.Rows.Clear();
            lblTotal.Text = "€0.00";

            if (cmbOrders.Text.Equals("Select the Order"))
            {
                return;
            }

            btnCancel.Enabled = true;
            cmbOrders.Items.Remove("Select the Order");

            Order order = cmbOrders.SelectedItem as Order;

            DataSet dsCompleted = OrderItem.GetMenuItemsFromOrder(order.ID, "Completed");

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

            Validation.UpdateTotal(dgvOrderDetails, lblTotal);

        }
    }
}
