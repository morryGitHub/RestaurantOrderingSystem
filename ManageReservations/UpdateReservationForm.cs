using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace RestaurantOrderingSystem
{
    public partial class FrmUpdateReservation : Form
    {

        private readonly int _reservationID;
        private int _tableID;
        private int _lastValidValue = 1;
        public FrmUpdateReservation(int reservationID, int tableID)
        {
            InitializeComponent();
            UIStyleHelper.ApplyDarkTheme(dgvTables);
            UIStyleHelper.ApplyPrimaryButtonStyle(btnFindAvailableTables);
            UIStyleHelper.ApplyPrimaryButtonStyle(btnUpdateReservation);

            UIStyleHelper.ApplyCancelButtonStyle(btnCancel);

            this._reservationID = reservationID;
            this._tableID = tableID;
        }

        private void FillComboBoxStatus()
        {
            cmbStatus.Items.Add("BOOKED");
            cmbStatus.Items.Add("CANCELLED");
        }

        private void UpdateReservationForm_Load(object sender, EventArgs e)
        {
            FillComboBoxStatus();
            ApplyReservationDesign();



            try
            {
                DataSet ds = Reservation.GetReservationDetails(_reservationID);

                if (ds != null)
                {
                    DataRow row = ds.Tables[0].Rows[0];

                    string custName = row["CUSTOMERNAME"]?.ToString() ?? "";
                    string custPhone = row["CUSTOMERPHONE"]?.ToString() ?? "";
                    DateTime date = Convert.ToDateTime(row["RESERVATIONDATETIMESTART"]);
                    int numOfGuest = Convert.ToInt32(row["NUMBEROFGUESTS"]);
                    int tableNo = Convert.ToInt32(row["TableNo"]);
                    int tableID = Convert.ToInt32(row["TableId"]);
                    int resID = Convert.ToInt32(row["RESERVATIONID"]);
                    string status = row["STATUS"].ToString().Trim();
                    int tableCapacity = Convert.ToInt32(row["CAPACITY"]);

                    string datePart = date.ToString("yyyy-MM-dd");     // only date
                    string timePart = date.ToString("HH:mm:ss");       // only time


                    tbCustName.Text = custName;
                    tbPhoneNumber.Text = custPhone;

                    datePicker.Text = datePart;
                    timePicker.Text = timePart;
                    tbTableNo.Text = tableNo.ToString();
                    numericNumOfGuests.Value = numOfGuest;
                    cmbStatus.SelectedItem = status;
                    tbTableCapacity.Text = tableCapacity.ToString();


                }
            }


            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading reservation details." + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            lblNumOfGuests.Font = normalFont;
            lblDate.Font = normalFont;
            lblTime.Font = normalFont;
            lblTableText.Font = normalFont;
            lblStatus.Font = normalFont;
            lblTableCapacity.Font = normalFont;

            tbCustName.Font = normalFont;
            tbPhoneNumber.Font = normalFont;
            numericNumOfGuests.Font = normalFont;
            datePicker.Font = normalFont;
            timePicker.Font = normalFont;
            cmbStatus.Font = normalFont;
            tbTableNo.Font = normalFont;
            tbTableCapacity.Font = normalFont;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
        "Update of reservation was cancelled.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void NumericNumOfGuests_ValueChanged(object sender, EventArgs e)
        {
            string guestCheck = Validation.IsSeatingCapacityValid((int)numericNumOfGuests.Value);
            if (guestCheck != "Valid")
            {

                MessageBox.Show(guestCheck, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numericNumOfGuests.Value = _lastValidValue;

                return;
            }
            else
            {
                _lastValidValue = (int)numericNumOfGuests.Value;
                BtnFindAvailableTables_Click(sender, e);
            }
        }

        private void BtnFindAvailableTables_Click(object sender, EventArgs e)
        {
            try
            {
                dgvTables.Rows.Clear();

                string dateCheck = Validation.IsDateValid(datePicker.Value, timePicker.Value);
                if (dateCheck != "Valid")
                {
                    MessageBox.Show(dateCheck, "Invalid Reservation Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    datePicker.Value = DateTime.Now.Date;
                    timePicker.Value = DateTime.Now + TimeSpan.FromHours(1);
                    return;
                }

                DateTime selectedStart = datePicker.Value.Date + timePicker.Value.TimeOfDay;


                string timeCheck = Validation.IsReservationTimeValid(selectedStart);
                if (timeCheck != "Valid")
                {
                    MessageBox.Show(timeCheck, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblErrorMsg.Visible = true;
                    return;
                }


                var tables = ReservationManager.GetAvailableTablesList(_lastValidValue, selectedStart);

                if (tables == null || tables.Count == 0)
                {
                    lblErrorMsg.Visible = true;
                    dgvTables.Visible = false;
                }
                else
                {
                    lblErrorMsg.Visible = false;
                    dgvTables.Visible = true;

                    tables.ForEach(row =>
                    {
                        dgvTables.Rows.Add(row.TableId, row.Number, row.Capacity, row.Location);
                    });
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching for tables:\n\n{ex.Message}",
                                        "Search Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
            }

            dgvTables.ClearSelection();
        }

        private void DgvTables_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) //  header click
            {
                DataGridViewRow row = dgvTables.Rows[e.RowIndex];

                string tableNo = row.Cells["TableNo"].Value.ToString();
                tbTableNo.Text = tableNo;

                string capacity = row.Cells["Capacity"].Value.ToString();
                tbTableCapacity.Text = capacity;

                _tableID = Convert.ToInt32(row.Cells["TableId"].Value);
            }
        }

        private void BtnUpdateReservation_Click(object sender, EventArgs e)
        {
            if (_tableID == -1)
            {
                MessageBox.Show("Time changed! Please pick a new table from the list.",
                               "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // Validate Name
            string nameCheck = Validation.IsNameValid(tbCustName.Text);
            if (nameCheck != "Valid")
            {
                MessageBox.Show(nameCheck, "Name Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime selectedStart = datePicker.Value.Date + timePicker.Value.TimeOfDay;
            string timeCheck = Validation.IsReservationTimeValid(selectedStart);
            if (timeCheck != "Valid")
            {
                MessageBox.Show(timeCheck, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblErrorMsg.Visible = true;
                return;
            }

            // Validate Phone
            string phoneCheck = Validation.IsPhoneValid(tbPhoneNumber.Text);
            if (phoneCheck != "Valid")
            {
                MessageBox.Show(phoneCheck, "Phone Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Date
            string dateCheck = Validation.IsDateValid(datePicker.Value, timePicker.Value);
            if (dateCheck != "Valid")
            {
                MessageBox.Show(dateCheck, "Invalid Reservation Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Guests
            string guestCheck = Validation.IsSeatingCapacityValid((int)numericNumOfGuests.Value);
            if (guestCheck != "Valid")
            {
                MessageBox.Show(guestCheck, "Guest Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            try
            {
                DateTime dateStart = datePicker.Value.Date;
                TimeSpan timeStart = timePicker.Value.TimeOfDay;
                DateTime startDateTime = dateStart + timeStart;

                DateTime dateEnd = datePicker.Value.Date;
                TimeSpan timeEnd = timePicker.Value.TimeOfDay;
                DateTime endDateTime = dateEnd + timeEnd + TimeSpan.FromHours(2);

                string start = startDateTime.ToString("yyyy-MM-dd HH:mm:ss");
                string end = endDateTime.ToString("yyyy-MM-dd HH:mm:ss");

                string customerName = tbCustName.Text.Trim();
                string customerPhone = tbPhoneNumber.Text;
                int numOfGuest = (int)numericNumOfGuests.Value;
                string status = cmbStatus.SelectedItem.ToString();
                int capacity = int.Parse(tbTableCapacity.Text);




                if (numOfGuest > capacity)
                {
                    MessageBox.Show($"There are no available tables for this group size.\n\n" +
                 $"The maximum capacity for the selected table is {capacity} guests. " +
                 "Please choose another table.",
                 "Capacity Limit Exceeded",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Warning);
                    return;
                }


                Reservation reservation = new Reservation(
                   _reservationID,
                   _tableID,
                   customerName,
                   customerPhone,
                   start,
                   end,
                   numOfGuest,
                   status);

                reservation.UpdateReservationDetails();

                MessageBox.Show("The reservation was successfully updated!",
                    "Update Complete",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);


                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the reservation: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }


        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {
            dgvTables.Rows.Clear();

            if (!datePicker.Focused) return;

            _tableID = -1;
            tbTableNo.Clear();
            tbTableCapacity.Clear();
            dgvTables.Rows.Clear();

           
        }

        private void TimePicker_ValueChanged(object sender, EventArgs e)
        {
            dgvTables.Rows.Clear();

            if (!timePicker.Focused) return;

            _tableID = -1;
            tbTableNo.Clear();
            tbTableCapacity.Clear();
            dgvTables.Rows.Clear();


        }

        private void BackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbCustName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
