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
    public partial class FrmReprintReceipt : Form
    {
        public FrmReprintReceipt()
        {
            InitializeComponent();
        }


      

        private void ReprintReceipt_Load(object sender, EventArgs e)
        {
            var normal = new Font("Segoe UI", 10, FontStyle.Regular);

            dgvOrderDetails.Font = normal;
            dgvOrderDetails.DefaultCellStyle.Font = normal;
            dgvOrderDetails.RowsDefaultCellStyle.Font = normal;
            dgvOrderDetails.AlternatingRowsDefaultCellStyle.Font = normal;

            dgvOrderDetails.ColumnHeadersDefaultCellStyle.Font = normal;
            dgvOrderDetails.RowHeadersDefaultCellStyle.Font = normal;

            dgvOrderDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrderDetails.ReadOnly = true;
            dgvOrderDetails.MultiSelect = false;

            dgvOrderDetails.ClearSelection();
        }

        private void dgvPayments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvOrderDetails.ClearSelection();
        }

      

    

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnRefund_Click(object sender, EventArgs e)
        {
            DataGridView dgvPayments = new DataGridView();
            dgvPayments.Columns.Add("Order", "Order");
            dgvPayments.Columns.Add("Method", "Method");
            dgvPayments.Columns.Add("Total", "Total");
            dgvPayments.Columns.Add("Date", "Date");

            dgvPayments.Rows.Add("P987", "Card", "24.00", "2025-12-01");

            string orderName = dgvPayments.Rows[0].Cells[0].Value.ToString();
            string method = dgvPayments.Rows[0].Cells[1].Value.ToString();
            decimal total = Convert.ToDecimal(dgvPayments.Rows[0].Cells[2].Value);

            FrmReceipt receipt = new FrmReceipt(orderName, method, total, dgvOrderDetails);
            receipt.ShowDialog();
        }

        private void cmbOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvOrderDetails.Rows.Clear();

            if (cmbOrders.SelectedIndex == 0)
            {
                dgvOrderDetails.Rows.Add("Pizza", "11.00", 2, "22.00");
                dgvOrderDetails.Rows.Add("Water", "2.00", 1, "2.00");
                lblTotal.Text = "€24.00";
            }
            else
            {
                dgvOrderDetails.Rows.Add("Steak", "18.00", 1, "18.00");
                dgvOrderDetails.Rows.Add("Cola", "3.50", 1, "3.50");
                lblTotal.Text = "€21.50";

            }
        }
    }
}
