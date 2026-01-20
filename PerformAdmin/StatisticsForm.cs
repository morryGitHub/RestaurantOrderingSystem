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
    public partial class frmStatistics : Form
    {
        public frmStatistics()
        {
            InitializeComponent();
        }

        

    


        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            var normal = new Font("Segoe UI", 10, FontStyle.Regular);

            dataStat.Font = normal;
            dataStat.DefaultCellStyle.Font = normal;
            dataStat.RowsDefaultCellStyle.Font = normal;
            dataStat.AlternatingRowsDefaultCellStyle.Font = normal;

            dataStat.ColumnHeadersDefaultCellStyle.Font = normal;
            dataStat.RowHeadersDefaultCellStyle.Font = normal;

            dataStat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataStat.ReadOnly = true;
            dataStat.MultiSelect = false;

            dataStat.ClearSelection();
        }

        private void btnGenerate_Click_1(object sender, EventArgs e)
        {
            dataStat.Rows.Add("Burger", "820");
            dataStat.Rows.Add("Pizza", "790");
            dataStat.Rows.Add("Steak", "640");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
