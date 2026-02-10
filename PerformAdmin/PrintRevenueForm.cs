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
            gridRevenue.Rows.Clear();

            gridRevenue.Rows.Add("May", "$234.43");
            gridRevenue.Rows.Add("June", "$924.54");
            gridRevenue.Rows.Add("July", "$4,324");

            lblTotal.Text = $"Total Revenue for {cmbYear.SelectedItem.ToString()}: {"$6,1234.95":C}";

        }


        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PrintRevenueForm_Load(object sender, EventArgs e)
        {

            var normal = new Font("Segoe UI", 10, FontStyle.Regular);

            gridRevenue.Font = normal;
            gridRevenue.DefaultCellStyle.Font = normal;
            gridRevenue.RowsDefaultCellStyle.Font = normal;
            gridRevenue.AlternatingRowsDefaultCellStyle.Font = normal;

            gridRevenue.ColumnHeadersDefaultCellStyle.Font = normal;
            gridRevenue.RowHeadersDefaultCellStyle.Font = normal;

            gridRevenue.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridRevenue.ReadOnly = true;
            gridRevenue.MultiSelect = false;

            gridRevenue.ClearSelection();
        }
    }
}
