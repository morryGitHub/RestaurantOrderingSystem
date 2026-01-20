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
            if (tableCheck != "valid")
            {
                MessageBox.Show(tableCheck, "Validation Error");
                return;
            }

            string seatingCheck = Validation.IsSeatingCapacityValid(numericSeatingCap.Value);
            if (seatingCheck != "valid")
            {
                MessageBox.Show(seatingCheck, "Validation Error");
                return;
            }

            MessageBox.Show(
                $"Table {numericTableNo.Value.ToString()} has been added!",
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

            this.Close(); // закрыть окно Add Table
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblTableNo_Click(object sender, EventArgs e)
        {

        }
    }
}
