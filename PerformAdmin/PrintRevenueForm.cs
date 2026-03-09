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

            FillRevenueGrid(selectedYear);



            //gridRevenue.Rows.Add("May", "$234.43");
            //gridRevenue.Rows.Add("June", "$924.54");
            //gridRevenue.Rows.Add("July", "$4,324");

            //lblTotal.Text = $"Total Revenue for {cmbYear.SelectedItem.ToString()}: {"$6,1234.95":C}";

        }


        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PrintRevenueForm_Load(object sender, EventArgs e)
        {

            var normal = new Font("Segoe UI", 10, FontStyle.Regular);

            dgvRevenue.Font = normal;
            dgvRevenue.DefaultCellStyle.Font = normal;
            dgvRevenue.RowsDefaultCellStyle.Font = normal;
            dgvRevenue.AlternatingRowsDefaultCellStyle.Font = normal;

            dgvRevenue.ColumnHeadersDefaultCellStyle.Font = normal;
            dgvRevenue.RowHeadersDefaultCellStyle.Font = normal;

            dgvRevenue.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRevenue.ReadOnly = true;
            dgvRevenue.MultiSelect = false;

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

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                string month = row["month_name"].ToString();
                decimal revenue = Convert.ToDecimal(row["revenue"]);

                dgvRevenue.Rows.Add(month, revenue.ToString("C"));
            }

        }

    }


}
