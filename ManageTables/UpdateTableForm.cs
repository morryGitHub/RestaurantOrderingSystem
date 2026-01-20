using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RestaurantOrderingSystem
{
    public partial class frmUpdateTable : Form
    {
        public frmUpdateTable()
        {
            InitializeComponent();
        }



   
        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void UpdateTableForm_Load(object sender, EventArgs e)
        {
           

        }

      

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Table updating cancelled.",
                "Cancelled",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            this.Close();
        }

        private void cmbTableNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTableNo.SelectedIndex == 0)
            {
                cmbStatus.Text = "A (Available)";
                numSeats.Value = 3;
            }
            else 
            {
                cmbStatus.Text = "O (Occupied)";
                numSeats.Value = 5;
            }

        }

        private void btnUpdateTable_Click(object sender, EventArgs e)
        {
            if (cmbTableNo.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a table number.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            string tableNo = cmbTableNo.SelectedItem.ToString();
            int seatingCapacity = (int)numSeats.Value;
            string status = cmbStatus.SelectedItem?.ToString() ?? "";

            string seatingCheck = Validation.IsSeatingCapacityValid(numSeats.Value);
            if (seatingCheck != "valid")
            {
                MessageBox.Show(seatingCheck,
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(status))
            {
                MessageBox.Show("Please select a table status.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(
                $"Table {tableNo} was successfully updated!\n\n" +
                $"New seating capacity: {seatingCapacity}\n" +
                $"New status: {status}",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            this.Close();
        }
    }
}
