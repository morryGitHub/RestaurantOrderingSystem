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
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
            UIStyleHelper.ApplyDarkTheme(dgvStats);
            UIStyleHelper.ApplyPrimaryButtonStyle(btnGenerate);
            UIStyleHelper.ApplyCancelButtonStyle(btnExit);

        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {

            this.BackColor = Color.White;

            // TITLE
            lblTitle.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(30, 30, 30);


        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                dgvStats.Columns.Clear();
                int selectedIndex = cmbCat.SelectedIndex;
                if (selectedIndex == 0)
                {
                    // Generate statistics for the top 10 menu items

                    dgvStats.Columns.Add("menuItemName", "Name");
                    dgvStats.Columns.Add("total", "Total");
                    dgvStats.Columns.Add("total_cost", "Total Cost");

                    Statistics.GetTopMenuItems().Tables[0].AsEnumerable().ToList().ForEach(row =>
                    {
                        dgvStats.Rows.Add(row["name"], row["total"], row["total_cost"]);
                    });

                    // Iterate through each row in the DataTable returned from the database
                    // and add it as a new row in the DataGridView, mapping DataTable columns
                    // ("name", "total", "total_cost") to the corresponding DataGridView columns.
                }
                else if (selectedIndex == 1)
                {
                    dgvStats.Columns.Add("menuItemName", "Name");
                    dgvStats.Columns.Add("total", "Total");
                    dgvStats.Columns.Add("total_cost", "Total Cost");

                    Statistics.GetLeastMenuItems().Tables[0].AsEnumerable().ToList().ForEach(row =>
                    {
                        dgvStats.Rows.Add(row["name"], row["total"], row["total_cost"]);
                    });

                }
                else if (selectedIndex == 2)
                {
                    // Generate statistics for never ordered items

                    dgvStats.Columns.Add("menuItemName", "Name");
                    dgvStats.Columns.Add("unitPrice", "Unit Price");

                    Statistics.GetNeverOrderedItems().Tables[0].AsEnumerable().ToList().ForEach(row =>
                    {
                        dgvStats.Rows.Add(row["name"], row["unit_price"]);
                    });



                }
                else if (selectedIndex == 3)
                {
                    // Generate statistics for total orders

                    Statistics.GetTotalOrders().Tables[0].AsEnumerable().ToList().ForEach(row =>
                    {
                        dgvStats.Columns.Add("totalOrders", "Total Orders");
                        dgvStats.Rows.Add(row["total_orders"]);
                    });
                }
                else if (selectedIndex == 4)
                {
                    // Generate statistics for avarage amount per order

                    Statistics.GetAverageAmountPerOrder().Tables[0].AsEnumerable().ToList().ForEach(row =>
                    {
                        dgvStats.Columns.Add("averageAmount", "Average Amount Per Order");
                        dgvStats.Rows.Add(row["average_amount"]);
                    });
                }
                else if (selectedIndex == 5)
                {
                    // Generate statistics for total revenue

                    Statistics.GetTotalRevenue().Tables[0].AsEnumerable().ToList().ForEach(row =>
                    {
                        dgvStats.Columns.Add("totalRevenue", "Total Revenue");
                        dgvStats.Rows.Add(row["total_revenue"]);
                    });
                }
                else if (selectedIndex == 6)
                {
                    // Generate statistics for total bookings

                    Statistics.GetTotalBookings().Tables[0].AsEnumerable().ToList().ForEach(row =>
                    {
                        dgvStats.Columns.Add("totalBookings", "Total Bookings");
                        dgvStats.Rows.Add(row["total_bookings"]);
                    });

                }
                else if (selectedIndex == 7)
                {
                    // Generate statistics for payments by method

                    dgvStats.Columns.Add("paymentMethod", "Payment Method");
                    dgvStats.Columns.Add("totalAmount", "Total Amount");

                    Statistics.GetPaymentsByMethod().Tables[0].AsEnumerable().ToList().ForEach(row =>
                    {
                        dgvStats.Rows.Add(row["payment_method"], row["total_amount"]);
                    });

                }
                else if (selectedIndex == 8)
                {
                    // Generate statistics for total refunded amount

                    Statistics.GetTotalRefundedAmount().Tables[0].AsEnumerable().ToList().ForEach(row =>
                    {
                        dgvStats.Columns.Add("totalRefundedAmount", "Total Refunded Amount");
                        dgvStats.Rows.Add(row["refunded_total"]);
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while generating statistics: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}