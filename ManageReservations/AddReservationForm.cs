using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RestaurantOrderingSystem
{
    public partial class FrmAddReservation : Form
    {
        public FrmAddReservation()
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


            string senderEmail = "morry.GitHub@gmail.com";
            string appPassword = "bveqapdowlnruikr";
            string recipientEmail = "rublykkolya@icloud.com";
            string emailSubject = "Test Email from C#";
            string emailBody = "<h1>Hello!</h1><p>This is a test email sent using Gmail SMTP in C#.</p>";

            GmailSender.SendEmail(senderEmail, appPassword, recipientEmail, emailSubject, emailBody);

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
            if (nameCheck != "Valid")
            {
                MessageBox.Show(nameCheck, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate Phone
            string phoneCheck = Validation.IsPhoneValid(tbPhoneNumber.Text);
            if (phoneCheck != "Valid")
            {
                MessageBox.Show(phoneCheck, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate Date & Time
            string dateCheck = Validation.IsDateValid(datePicker.Value, timePicker.Value);
            if (dateCheck != "Valid")
            {
                MessageBox.Show(dateCheck, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate Guests
            string guestCheck = Validation.IsGuestsValid((int)numericNumOfGuests.Value);
            if (guestCheck != "Valid")
            {
                MessageBox.Show(guestCheck, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate Table Selection
            string tableCheck = Validation.IsGridSelected(dgvTables, "Table");
            if (tableCheck != "Valid")
            {
                MessageBox.Show(tableCheck, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataGridViewRow row = dgvTables.SelectedRows[0];
            int tableID = Convert.ToInt32(row.Cells["TableID"].Value);

            int numOfGuest = (int)numericNumOfGuests.Value;
            DateTime startDateTime = datePicker.Value.Date
                         + timePicker.Value.TimeOfDay;

            string start = startDateTime.ToString("dd-MM-yyyy HH:mm");

            DateTime date = datePicker.Value.Date;
            TimeSpan time = timePicker.Value.TimeOfDay;
            DateTime endDateTime = date + time + TimeSpan.FromHours(2);

            string end = endDateTime.ToString("dd-MM-yyyy HH:mm");

            string customerName = tbCustName.Text;
            string customerPhone = tbPhoneNumber.Text;

            Reservation reservation = new Reservation(
                tableID,
                customerName,
                customerPhone,
                end,
                start,
                numOfGuest);


            reservation.AddReservation();



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

            lblErrorMsg.Visible = false;
            dgvTables.Visible = true;

            int numOfGuest = (int)numericNumOfGuests.Value;
            DateTime startDateTime = datePicker.Value.Date
                         + timePicker.Value.TimeOfDay;

            string start = startDateTime.ToString("dd-MM-yyyy HH:mm");

            DateTime date = datePicker.Value.Date;
            TimeSpan time = timePicker.Value.TimeOfDay;
            DateTime endDateTime = date + time + TimeSpan.FromHours(2);

            string end = endDateTime.ToString("dd-MM-yyyy HH:mm");

            // Validate Date & Time
            //string dateCheck = Validation.IsDateValid(datePicker.Value, timePicker.Value);
            //if (dateCheck != "valid")
            //{
            //    MessageBox.Show(dateCheck, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //// Validate Guests
            //string guestCheck = Validation.IsGuestsValid(numOfGuest);
            //if (guestCheck != "valid")
            //{
            //    MessageBox.Show(guestCheck, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            DataSet ds = Reservation.GetAvailableTablesForReservation(numOfGuest, start, end);

            if (ds.Tables[0].Rows.Count == 0)
            {
                lblErrorMsg.Visible = true;
                dgvTables.Visible = false;
            }
            else
            {

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int tableID = Convert.ToInt32(row["Table_ID"]);
                    int tableNo = Convert.ToInt32(row["Table_No"]);
                    int capacity = Convert.ToInt32(row["Capacity"]);
                    string status = row["Status"].ToString();

                    dgvTables.Rows.Add(tableID, tableNo, capacity, status);
                }
            }



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

        private void tbCustName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
