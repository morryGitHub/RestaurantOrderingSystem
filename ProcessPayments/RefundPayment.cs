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
    public partial class FrmRefundPayment : Form
    {
        public FrmRefundPayment()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Refund cancelled.", "Cancelled");
            this.Close();
        }


        private void frmRefundPayment_Load(object sender, EventArgs e)
        {
            // Define standard font
            var normal = new Font("Segoe UI", 10, FontStyle.Regular);

            // 1. FORM STYLE
            this.BackColor = Color.White;

            // 2. TITLE STYLE
            // Assuming you have a label named lblTitle for consistency
            lblTitle.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(30, 30, 30);

            // 3. DATAGRID STYLE (dgvPayments)
            dgvPayments.BorderStyle = BorderStyle.None;
            dgvPayments.EnableHeadersVisualStyles = false;

            // Header Styles (Dark Gray background, White text)
            dgvPayments.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48);
            dgvPayments.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvPayments.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvPayments.ColumnHeadersHeight = 35;

            // Body Styles
            dgvPayments.DefaultCellStyle.Font = normal;
            dgvPayments.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            // If you want to disable the blue highlight like the Revenue form, use:
            // dgvPayments.DefaultCellStyle.SelectionBackColor = dgvPayments.DefaultCellStyle.BackColor;
            // dgvPayments.DefaultCellStyle.SelectionForeColor = dgvPayments.DefaultCellStyle.ForeColor;

            dgvPayments.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvPayments.ColumnHeadersDefaultCellStyle.BackColor;
            dgvPayments.ColumnHeadersDefaultCellStyle.SelectionForeColor = dgvPayments.ColumnHeadersDefaultCellStyle.ForeColor;

            dgvPayments.RowHeadersVisible = false;
            dgvPayments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPayments.AllowUserToAddRows = false;
            dgvPayments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPayments.ReadOnly = true;

            // 4. BUTTONS STYLE
            StyleButton(btnRefund);               // Primary Blue
            StyleButton(btnCancel, isSecondary: true); // Secondary Gray (Cancel)

            // 5. DATA LOADING
            dgvPayments.ClearSelection();
            FillPaidPaymentsComboBox();
        }

        // Helper method to maintain consistent button design
        private void StyleButton(Button btn, bool isSecondary = false)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            if (!isSecondary)
            {
                // Primary Blue Style (like btnGenerate)
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

        private void cmbOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvPayments.Rows.Clear();
            Order order = cmbOrders.SelectedItem as Order;
            DataSet ds = Payment.GetCompletedOrderDetails(order.ID);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                int paymentID = Convert.ToInt32(row["paymentID"]);
                string methodType = row["methodType"].ToString();
                decimal amount = Convert.ToDecimal(row["amount"]);
                DateTime paymentDate = Convert.ToDateTime(row["paymentDate"]);


                dgvPayments.Rows.Add(
                        paymentID,
                        paymentDate.ToString("dd-MM-yyyy HH:mm"),
                        methodType,
                        amount.ToString("F2")
                      
                );
            }
        }

        private void btnRefund_Click(object sender, EventArgs e)
        {

            if (cmbOrders.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an order.");
                return;
            }

            if (dgvPayments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a payment to refund.");
                return;
            }

            int paymentID = Convert.ToInt32(dgvPayments.SelectedRows[0].Cells["ID"].Value);
            string amount = dgvPayments.SelectedRows[0].Cells["Amount"].Value.ToString();

            Payment.RefundPayment(paymentID);

            MessageBox.Show(
                $"Refund processed successfully.\n" +
                $"Payment ID: {paymentID}\n" +
                $"Refund Amount: €{amount:F2}",
                "Refund Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            this.Close();
        }

        private void dgvPayments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvPayments.ClearSelection();
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
    }
}
