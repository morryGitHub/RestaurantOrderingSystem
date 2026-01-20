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
    public partial class frmAddReservation : Form
    {
        public frmAddReservation()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var normal = new Font("Segoe UI", 10, FontStyle.Regular);

            dgvTables.Font = normal;
            dgvTables.DefaultCellStyle.Font = normal;
            dgvTables.RowsDefaultCellStyle.Font = normal;
            dgvTables.AlternatingRowsDefaultCellStyle.Font = normal;

            dgvTables.ColumnHeadersDefaultCellStyle.Font = normal;
            dgvTables.RowHeadersDefaultCellStyle.Font = normal;

            dgvTables.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTables.ReadOnly = true;
            dgvTables.MultiSelect = false;

            dgvTables.ClearSelection();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to cancel this reservation?",
                "Confirm Cancellation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                MessageBox.Show(
                    "Reservation was successfully cancelled!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                this.Close();
            }
        }


        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            // Validate Name
            string nameCheck = Validation.IsNameValid(tbCustName.Text);
            if (nameCheck != "valid")
            {
                MessageBox.Show(nameCheck, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate Phone
            string phoneCheck = Validation.IsPhoneValid(tbPhoneNumber.Text);
            if (phoneCheck != "valid")
            {
                MessageBox.Show(phoneCheck, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate Date & Time
            string dateCheck = Validation.IsDateValid(datePicker.Value, timePicker.Value);
            if (dateCheck != "valid")
            {
                MessageBox.Show(dateCheck, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate Guests
            string guestCheck = Validation.IsGuestsValid((int)numericNumOfGuests.Value);
            if (guestCheck != "valid")
            {
                MessageBox.Show(guestCheck, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate Table Selection
            string tableCheck = Validation.IsGridSelected(dgvTables, "Table");
            if (tableCheck != "valid")
            {
                MessageBox.Show(tableCheck, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Reservation was successfully added!",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            this.Close();
            

        }


        private void cbAvailableTables_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFindAvailableTables_Click(object sender, EventArgs e)
        {
            dgvTables.Rows.Clear();

            // Validate Date & Time
            string dateCheck = Validation.IsDateValid(datePicker.Value, timePicker.Value);
            if (dateCheck != "valid")
            {
                MessageBox.Show(dateCheck, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate Guests
            string guestCheck = Validation.IsGuestsValid((int)numericNumOfGuests.Value);
            if (guestCheck != "valid")
            {
                MessageBox.Show(guestCheck, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgvTables.Rows.Add("1", "2", "Available");
            dgvTables.Rows.Add("5", "4", "Available");
            dgvTables.Rows.Add("7", "6", "Available"); ;
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void lblPhoneNum_Click(object sender, EventArgs e)
        {

        }

        private void dgvTables_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
