using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RestaurantOrderingSystem
{
    public partial class frmUpdateReservation : Form
    {

        private DataGridViewRow row;
        public frmUpdateReservation(DataGridViewRow reservation)
        {
            InitializeComponent();
            this.row = reservation;

            string customerName = row.Cells["colName"].Value.ToString();
            string phone = row.Cells["Phone"].Value.ToString();
            string date = row.Cells["Date"].Value.ToString();
            string time = row.Cells["Time"].Value.ToString();
            string numberOfGuests = row.Cells["Guests"].Value.ToString();
            string table = row.Cells["Table"].Value.ToString();

            tbCustName.Text = customerName;
            tbPhoneNumber.Text = phone;
            datePicker.Value = DateTime.Parse(date);
            timePicker.Value = DateTime.Parse(time);
            numericNumOfGuests.Value = Decimal.Parse(numberOfGuests);
            tbTableNo.Text = table;

        }

        private void UpdateReservationForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tbCustName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableNum_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFindAvailableTable_Click(object sender, EventArgs e)
        {
        }

        private void cmbAvailableTables_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

      
        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
        "Update of reservation was cancelled." , "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }


        private void tbCustName_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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

            // Validate Date
            string dateCheck = Validation.IsDateValid(datePicker.Value, timePicker.Value);
            if (dateCheck != "valid")
            {
                MessageBox.Show(dateCheck, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate Guests
            if (numericNumOfGuests.Value <= 0)
            {
                MessageBox.Show("Guests must be at least 1.");
                return;
            }

            // If all good → update the row
            row.Cells[0].Value = tbCustName.Text;
            row.Cells[1].Value = tbPhoneNumber.Text;
            row.Cells[2].Value = datePicker.Value.ToShortDateString();
            row.Cells[3].Value = timePicker.Value.ToShortTimeString();
            row.Cells[4].Value = numericNumOfGuests.Value.ToString();
            row.Cells[5].Value = tbTableNo.Text;

            // Success message
            MessageBox.Show("The reservation was successfully updated!",
                "Update Complete",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            this.Close();
        }

        private void lblTableInfoText_Click(object sender, EventArgs e)
        {

        }

        private void numericNumOfGuests_ValueChanged(object sender, EventArgs e)
        {
            lblTableInfo.ForeColor = Color.Red;
            lblTableInfo.Text = "Table Not Suitable\nSelect a new table";
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

        private void dgvTables_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // защитa от header click
            {
                DataGridViewRow row = dgvTables.Rows[e.RowIndex];

                // например, взять TableNo из первой колонки
                string tableNo = row.Cells[0].Value.ToString();

                tbTableNo.Text = tableNo;
                lblTableInfo.Text = "The current table meets all requirements.";
                lblTableInfo.ForeColor = Color.Green;
            }
        }

        private void lblTableInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
