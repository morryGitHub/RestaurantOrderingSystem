using RestaurantOrderingSystem.OracleDatabase;
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
    public partial class FrmPrintRevenue : Form
    {
        public FrmPrintRevenue()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (cmbYear.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select a year.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            dgvRevenue.Rows.Clear();

            int selectedYear;
            if (cmbYear.SelectedItem is Statistics stat)
            {
                selectedYear = stat.Year;
            }
            else
            {
                MessageBox.Show(
                    "Unable to determine the selected year.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            FormIncomeAnalysis_Load(selectedYear);

            FillRevenueGrid(selectedYear);
        }



        private void PrintRevenueForm_Load(object sender, EventArgs e)
        {

            var normal = new Font("Segoe UI", 10, FontStyle.Regular);

            this.BackColor = Color.White;
            lblTitle.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(30, 30, 30);

            dgvRevenue.BorderStyle = BorderStyle.None;
            dgvRevenue.EnableHeadersVisualStyles = false;

            dgvRevenue.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48);
            dgvRevenue.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvRevenue.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            dgvRevenue.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvRevenue.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dgvRevenue.DefaultCellStyle.SelectionBackColor = dgvRevenue.DefaultCellStyle.BackColor;
            dgvRevenue.DefaultCellStyle.SelectionForeColor = dgvRevenue.DefaultCellStyle.ForeColor;

            dgvRevenue.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvRevenue.ColumnHeadersDefaultCellStyle.BackColor;
            dgvRevenue.ColumnHeadersDefaultCellStyle.SelectionForeColor = dgvRevenue.ColumnHeadersDefaultCellStyle.ForeColor;

            dgvRevenue.RowHeadersVisible = false;
            dgvRevenue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.BackColor = Color.FromArgb(0, 120, 215);
            btnGenerate.ForeColor = Color.White;
            btnGenerate.FlatAppearance.BorderSize = 0;

            lblTotal.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(50, 50, 50); 



            dgvRevenue.ClearSelection();
            FillYearsComboBox();
        }

        public void FillYearsComboBox()
        {
            cmbYear.Items.Clear();
            List<Statistics> years = Statistics.LoadYears();

            foreach (Statistics year in years)
            {
                cmbYear.Items.Add(year);

            }
        }

        public void FillRevenueGrid(int year)
        {
            Statistics stat = new Statistics(year);
            DataSet ds = stat.GetYearlyRevenue();
            decimal total = 0;

            string[] months =
        {
            "JAN","FEB","MAR","APR","MAY","JUN",
            "JUL","AUG","SEP","OCT","NOV","DEC"
        };

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                int monthIndex = Convert.ToInt32(row["month_num"]);
                decimal revenue = Convert.ToDecimal(row["revenue"]);
                total += revenue;

                dgvRevenue.Rows.Add(months[monthIndex-1], revenue.ToString("C"));
            }

            FillRevenueTotal(lblTotal, year, total);
        }

        private void FillRevenueTotal(Label label, int year, decimal total)
        {
            label.Text = $"Total Revenue for {year}: {total:C}";
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void FormIncomeAnalysis_Load(int year)
        {

            Statistics stat = new Statistics(year);
            DataSet ds = stat.GetYearlyRevenue();

            //Initialise the arrays

            string[] months = { "JAN", "FEB", "MAR", "APR", "MAY", "JUN", "JUL", "AUG", "SEP", "OCT", "NOV", "DEC" };

            decimal[] amounts = new decimal[12];

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                int month = Convert.ToInt32(ds.Tables[0].Rows[i]["month_num"]);
                decimal revenue = Convert.ToDecimal(ds.Tables[0].Rows[i]["revenue"]);

                amounts[month - 1] = revenue;
            }
            chtData.BackColor = Color.White;

            chtData.ChartAreas[0].BackColor = Color.White;

            chtData.ChartAreas[0].AxisX.LineColor = Color.LightGray;
            chtData.ChartAreas[0].AxisY.LineColor = Color.LightGray;

            chtData.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Gainsboro;
            chtData.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Gainsboro;
            chtData.Series[0].Color = Color.FromArgb(0, 120, 215);
            chtData.Series[0].LabelFormat = "C0"; // €1234

            chtData.Legends.Clear();

            //decide if you want grid lines on the chart (none at present)

            chtData.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chtData.ChartAreas[0].AxisX.Interval = 1;
            chtData.ChartAreas[0].AxisX.IsMarginVisible = true;

            chtData.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;


            //tie the arrays to the x and y axes of the chart

            chtData.Series[0].Points.DataBindXY(months, amounts);


            //the amounts will appear atop the bars in the chart


            chtData.Series[0].Label = "#VALY";

            //chtData.ChartAreas[0].AxisX.Title = "Month"; //x-axis title

            //chtData.ChartAreas[0].AxisY.Title = "Income"; //y-axis title


            chtData.Visible = true;

        }

        private void chtData_Click(object sender, EventArgs e)
        {

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
