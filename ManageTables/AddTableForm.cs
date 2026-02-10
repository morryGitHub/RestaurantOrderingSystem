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
    public partial class FrmAddTable : Form
    {
        public FrmAddTable()
        {
            InitializeComponent();
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            string seatingCheck = Validation.IsSeatingCapacityValid(numericSeatingCap.Value);

            if (seatingCheck != "valid")
            {
                MessageBox.Show(seatingCheck, "Validation Error");
                return;
            }


            Table table = new Table(Convert.ToInt16(tableNum.Text),(int)numericSeatingCap.Value);
            table.AddTable();

            MessageBox.Show(
                $"Table {tableNum.Text} has been added!",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            this.Close();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Table creation was cancelled.",
                "Cancelled",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            this.Close();
        }
        private void AddTableForm_Load(object sender, EventArgs e)
        {
            int freeNo = Table.GetLastTableID();
            tableNum.Text = freeNo.ToString();
           
            
        }

        private void tableNum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
