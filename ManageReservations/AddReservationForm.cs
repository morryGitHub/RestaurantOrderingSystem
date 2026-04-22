using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
            UIStyleHelper.ApplyDarkTheme(dgvAddTables);
            UIStyleHelper.ApplyPrimaryButtonStyle(btnAddReservation);
            UIStyleHelper.ApplyPrimaryButtonStyle(btnFindAvailableTables);
            UIStyleHelper.ApplyCancelButtonStyle(btnCancel);

        }

        private void FrmAddReservation_Load(object sender, EventArgs e)
        {
            ApplyReservationDesign();


        }

 


        private void BtnAddReservation_Click(object sender, EventArgs e)
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

            // Validate Enail
            string emailCheck = Validation.IsEmailValid(tbEmail.Text);
            if (emailCheck != "Valid")
            {
                MessageBox.Show(emailCheck, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            string tableCheck = Validation.IsGridSelected(dgvAddTables, "Table");
            if (tableCheck != "Valid")
            {
                MessageBox.Show(tableCheck, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                DataGridViewRow row = dgvAddTables.SelectedRows[0];
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
                    start,
                    end,
                    numOfGuest);


                reservation.AddReservation();


                MessageBox.Show(
                    "Reservation was successfully added!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                string recipientEmail = tbEmail.Text;
                string emailSubject = "Your Table Reservation is Confirmed!";
                string emailBody = $"<h1>Hello {customerName}!</h1>" +
                       $"<p>Thank you for booking with us. Your reservation is confirmed.</p>" +
                       $"<p><strong>Reservation Details:</strong></p>" +
                       $"<table border='1' cellpadding='5'>" +
                       $"<tr><td>Table</td><td>{row.Cells["TableNo"].Value}</td></tr>" +
                       $"<tr><td>Guests</td><td>{numOfGuest}</td></tr>" +
                       $"<tr><td>From</td><td>{start}</td></tr>" +
                       $"<tr><td>To</td><td>{end}</td></tr>" +
                       $"</table>" +
                       $"<p>See you soon!</p>";


                try
                {
                    Task sendTask = Task.Run(() => GmailSender.SendEmail(recipientEmail, emailSubject, emailBody));

                    if (!sendTask.Wait(2000))

                        throw new TimeoutException("Email sending took too long.");
                }

                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the reservation: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnFindAvailableTables_Click(object sender, EventArgs e)
        {
            try
            {
                dgvAddTables.Rows.Clear();
                DateTime selectedStart = datePicker.Value.Date + timePicker.Value.TimeOfDay;

                int hour = selectedStart.Hour;
                if (hour < 8 || hour >= 23)
                {
                    MessageBox.Show("Reservations are only available between 08:00 and 23:00.",
                                    "Invalid Time", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string guestCheck = Validation.IsGuestsValid((int)numericNumOfGuests.Value);
                if (guestCheck != "Valid")
                {
                    MessageBox.Show(guestCheck, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var tables = ReservationManager.GetAvailableTablesList((int)numericNumOfGuests.Value, selectedStart);

                if (tables.Count == 0)
                {
                    lblErrorMsg.Visible = true;
                    dgvAddTables.Visible = false;
                }
                else
                {
                    lblErrorMsg.Visible = false;
                    dgvAddTables.Visible = true;

                    tables.ForEach(row =>
                    {
                        dgvAddTables.Rows.Add(row.TableId, row.TableNumber, row.Capacity, row.Location);
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void DateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            dgvAddTables.Rows.Clear();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
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



        private void TimePicker_ValueChanged(object sender, EventArgs e)
        {
            dgvAddTables.Rows.Clear();

        }

        private void NumericNumOfGuests_ValueChanged(object sender, EventArgs e)
        {
            dgvAddTables.Rows.Clear();

        }

        private void BackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void ApplyReservationDesign()
        {
            var normalFont = new Font("Segoe UI", 10, FontStyle.Regular);
            var boldFont = new Font("Segoe UI", 10, FontStyle.Bold);

            this.BackColor = Color.White;

            lblTitle.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(30, 30, 30);

            grpCustomerInfo.Font = boldFont;
            grpCustomerInfo.ForeColor = Color.FromArgb(50, 50, 50);

            grpReservationDetails.Font = boldFont;
            grpReservationDetails.ForeColor = Color.FromArgb(50, 50, 50);

            lblCustName.Font = normalFont;
            lblPhoneNum.Font = normalFont;
            lblEmail.Font = normalFont;
            lblDate.Font = normalFont;
            lblTime.Font = normalFont;
            lblNumOfGuests.Font = normalFont;

            tbCustName.Font = normalFont;
            tbPhoneNumber.Font = normalFont;
            tbEmail.Font = normalFont;
            numericNumOfGuests.Font = normalFont;
            datePicker.Font = normalFont;
            timePicker.Font = normalFont;

            this.ActiveControl = tbCustName;
        }
    }
}
