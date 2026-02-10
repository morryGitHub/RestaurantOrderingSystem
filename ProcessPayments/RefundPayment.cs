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
        }

        private void cmbOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvPayments.Rows.Clear();

            if (cmbOrders.SelectedIndex == 0)
            {
                dgvPayments.Rows.Add("P987", "Card", "24.00", "2025-12-01");
            }
            else
            {
                dgvPayments.Rows.Add("P990", "Cash", "18.00", "2025-12-03");
                dgvPayments.Rows.Add("P991", "Cash", "3.50", "2025-12-03");
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

            string paymentID = dgvPayments.SelectedRows[0].Cells["ID"].Value.ToString();
            string amount = dgvPayments.SelectedRows[0].Cells["Amount"].Value.ToString();

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
    }
}
