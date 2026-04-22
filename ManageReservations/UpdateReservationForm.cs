using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RestaurantOrderingSystem
{
    public partial class FrmUpdateReservation : Form
    {

        private readonly int reservationID;
        private int tableID;
        public FrmUpdateReservation(int reservationID, int tableID)
        {
            InitializeComponent();
            UIStyleHelper.ApplyDarkTheme(dgvTables);
            UIStyleHelper.ApplyPrimaryButtonStyle(btnFindAvailableTables);
            UIStyleHelper.ApplyPrimaryButtonStyle(btnUpdateReservation);

            UIStyleHelper.ApplyCancelButtonStyle(btnCancel);

            this.reservationID = reservationID;
            this.tableID = tableID;
        }

        private void UpdateReservationForm_Load(object sender, EventArgs e)
        {

            cmbStatus.Items.Add("BOOKED");
            cmbStatus.Items.Add("CANCELLED");


            try
            {
                DataSet ds = Reservation.GetReservationDetails(reservationID);

                if (ds != null)
                {
                    DataRow row = ds.Tables[0].Rows[0];

                    string custName = row["CUSTOMERNAME"]?.ToString() ?? "";
                    string custPhone = row["CUSTOMERPHONE"]?.ToString() ?? "";
                    DateTime date = Convert.ToDateTime(row["RESERVATIONDATETIMESTART"]);
                    int numOfGuest = Convert.ToInt32(row["NUMBEROFGUESTS"]);
                    int tableNo = Convert.ToInt32(row["TableNo"]);
                    int tableID = Convert.ToInt32(row["TableID"]);
                    int resID = Convert.ToInt32(row["RESERVATIONID"]);
                    string status = row["STATUS"].ToString().Trim();

                    string datePart = date.ToString("yyyy-MM-dd");     // only date
                    string timePart = date.ToString("HH:mm:ss");       // only time


                    tbCustName.Text = custName;
                    tbPhoneNumber.Text = custPhone;

                    datePicker.Text = datePart;
                    timePicker.Text = timePart;
                    tbTableNo.Text = tableNo.ToString();
                    numericNumOfGuests.Value = numOfGuest;
                    cmbStatus.SelectedItem = status;


                }
            }


            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading reservation details." + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        "Update of reservation was cancelled.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }


        private void tbCustName_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void lblTableInfoText_Click(object sender, EventArgs e)
        {

        }

        private void numericNumOfGuests_ValueChanged(object sender, EventArgs e)
        {
            dgvTables.Rows.Clear();
        }

        private void btnFindAvailableTables_Click(object sender, EventArgs e)
        {
            try
            {
                dgvTables.Rows.Clear();

                dgvTables.Visible = true;

                int numOfGuest = (int)numericNumOfGuests.Value;
                DateTime startDateTime = datePicker.Value.Date
                             + timePicker.Value.TimeOfDay;

                string start = startDateTime.ToString("dd-MM-yyyy HH:mm");

                DateTime date = datePicker.Value.Date;
                TimeSpan time = timePicker.Value.TimeOfDay;
                DateTime endDateTime = date + time + TimeSpan.FromHours(2);

                string end = endDateTime.ToString("dd-MM-yyyy HH:mm");

                DataSet ds = Reservation.GetAvailableTablesForReservation(numOfGuest, start, end);

                if (ds.Tables[0].Rows.Count == 0)
                {
                    //lblErrorMsg.Visible = true;
                    dgvTables.Visible = false;
                }
                else
                {

                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        int tableID = Convert.ToInt32(row["TableID"]);
                        int tableNo = Convert.ToInt32(row["TableNo"]);
                        int capacity = Convert.ToInt32(row["Capacity"]);
                        string status = row["Status"].ToString();

                        dgvTables.Rows.Add(tableID, tableNo, capacity, status);
                    }
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching available tables: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvTables_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) //  header click
            {
                DataGridViewRow row = dgvTables.Rows[e.RowIndex];

                string tableNo = row.Cells["TableNo"].Value.ToString();
                this.tableID = Convert.ToInt32(row.Cells["TableID"].Value);

                tbTableNo.Text = tableNo;
            }
        }

        private void lblTableInfo_Click(object sender, EventArgs e)
        {

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbTableNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdateReservation_Click(object sender, EventArgs e)
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

            // Validate Date
            string dateCheck = Validation.IsDateValid(datePicker.Value, timePicker.Value);
            if (dateCheck != "Valid")
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

                string customerName = tbCustName.Text;
                string customerPhone = tbPhoneNumber.Text;
                int numOfGuest = (int)numericNumOfGuests.Value;
                string status = cmbStatus.SelectedItem.ToString();

                Reservation reservation = new Reservation(
                   reservationID,
                   tableID,
                   customerName,
                   customerPhone,
                   start,
                   end,
                   numOfGuest,
                   status);

                reservation.UpdateReservationDetails();

                // Success message
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

        private void dgvTables_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            dgvTables.Rows.Clear();
        }

        private void timePicker_ValueChanged(object sender, EventArgs e)
        {
            dgvTables.Rows.Clear();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
