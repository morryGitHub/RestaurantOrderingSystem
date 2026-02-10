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
    public partial class FrmCancelOrder : Form
    {
        public FrmCancelOrder()
        {
            InitializeComponent();
        }

        private void frmCancelOrder_Load(object sender, EventArgs e)
        {
            {
                var normal = new Font("Segoe UI", 10, FontStyle.Regular);

                dgvOrderItems.Font = normal;
                dgvOrderItems.DefaultCellStyle.Font = normal;
                dgvOrderItems.RowsDefaultCellStyle.Font = normal;
                dgvOrderItems.AlternatingRowsDefaultCellStyle.Font = normal;

                dgvOrderItems.ColumnHeadersDefaultCellStyle.Font = normal;
                dgvOrderItems.RowHeadersDefaultCellStyle.Font = normal;

                dgvOrderItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvOrderItems.ReadOnly = true;
                dgvOrderItems.MultiSelect = false;

                dgvOrderItems.ClearSelection();
            }
        }

        private void cmbOrders_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            dgvOrderItems.Rows.Clear();

            if (cmbOrders.SelectedIndex == 0)
            {
                dgvOrderItems.Rows.Add("Burger", "8.50", 2, "17.00");
                dgvOrderItems.Rows.Add("Cola", "3.00", 1, "3.00");
                lblTotal.Text = "€20.00";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (cmbOrders.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an order to cancel.");
                return;
            }

            string orderName = cmbOrders.SelectedItem.ToString();

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to cancel {orderName}?",
                "Confirm Cancellation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result != DialogResult.Yes)
                return;


            MessageBox.Show(
                $"Order {orderName} was successfully cancelled.\nTable is now available.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void dgvOrderItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
