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
    public partial class AddTableForm : Form
    {
        public AddTableForm()
        {
            InitializeComponent();
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            string tableCheck = Validation.IsSeatingCapacityValid(numericTableNo.Value);
            string seatingCheck = Validation.IsSeatingCapacityValid(numericSeatingCap.Value);

            if (tableCheck != "valid" || seatingCheck != "valid")
            {
                string errorMsg = tableCheck != "valid" ? tableCheck : seatingCheck;
                MessageBox.Show(errorMsg, "Validation Error");
                return;
            }

            Table table = new Table((int)numericTableNo.Value, (int)numericSeatingCap.Value);
            table.AddTable();

            MessageBox.Show(
                $"Table {numericTableNo.Value} has been added!",
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblTableNo_Click(object sender, EventArgs e)
        {

        }
    }
}
