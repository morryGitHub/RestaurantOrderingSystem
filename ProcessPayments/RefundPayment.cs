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
            var normal = new Font("Segoe UI", 10, FontStyle.Regular);

            dgvPayments.Font = normal;
            dgvPayments.DefaultCellStyle.Font = normal;
            dgvPayments.RowsDefaultCellStyle.Font = normal;
            dgvPayments.AlternatingRowsDefaultCellStyle.Font = normal;

            dgvPayments.ColumnHeadersDefaultCellStyle.Font = normal;
            dgvPayments.RowHeadersDefaultCellStyle.Font = normal;

            dgvPayments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPayments.ReadOnly = true;

            dgvPayments.ClearSelection();
            FillPaidPaymentsComboBox();


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
                        methodType,
                        amount.ToString("F2"),
                        paymentDate.ToString("dd-MM-yyyy HH:mm")
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
