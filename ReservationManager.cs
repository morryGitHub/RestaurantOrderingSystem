using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantOrderingSystem
{
    internal class ReservationManager
    {
        public static void GetReservations(DataGridView dgvMatchingReservation, RadioButton rbCustName, TextBox tbCustName, TextBox tbPhoneNum, Label resInfo)
        {
            dgvMatchingReservation.Rows.Clear();
            dgvMatchingReservation.Visible = true;
            resInfo.Visible = false;

            string phone = null;
            string name = null;

            if (rbCustName.Checked)
            {
                name = tbCustName.Text;
                string nameResult = Validation.IsNameValid(name);

                if (nameResult != "Valid")
                {
                    MessageBox.Show(nameResult,
                                    "Customer Name Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    resInfo.Visible = true;
                    return;
                }
            }
            else
            {
                phone = tbPhoneNum.Text;
                string phoneResult = Validation.IsPhoneValid(phone); 
                if (phoneResult != "Valid")
                {
                    MessageBox.Show(phoneResult,
                                    "Phone Number Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    resInfo.Visible = true;
                    return;
                }
            }

            try
            {
                dgvMatchingReservation.Rows.Clear();

                DataSet ds = Reservation.GetReservationDetails(phone, name);

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dgvMatchingReservation.Visible = true;
                    resInfo.Visible = false;

                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        string custName = row["CUSTOMERNAME"]?.ToString().Trim() ?? "";
                        string custPhone = row["CUSTOMERPHONE"]?.ToString().Trim() ?? "";
                        string date = row["RESERVATIONDATETIMESTART"]?.ToString().Trim() ?? "";
                        int numOfGuest = Convert.ToInt32(row["NUMBEROFGUESTS"]);
                        int tableNo = Convert.ToInt32(row["TableNo"]);
                        int tableID = Convert.ToInt32(row["TableId"]);
                        int resID = Convert.ToInt32(row["RESERVATIONID"]);

                        dgvMatchingReservation.Rows.Add(
                            custName,
                            custPhone,
                            date,
                            numOfGuest,
                            tableNo,
                            tableID,
                            resID
                        );
                    }
                }
                else
                {
                    dgvMatchingReservation.Visible = false;
                    resInfo.Visible = true;
                    return;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during search: " + ex.Message,
                                "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static List<Table> GetAvailableTablesList(int guests, DateTime start)
        {
            DateTime endDateTime = start.AddHours(2);

            string startStr = start.ToString("dd-MM-yyyy HH:mm");
            string endStr = endDateTime.ToString("dd-MM-yyyy HH:mm");

            Reservation reservation = new Reservation(startStr, endStr, guests);
            DataSet ds = reservation.GetAvailableTablesForReservation();
            List<Table> availableTables = new List<Table>();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                availableTables.Add(new Table(
                    Convert.ToInt32(row["TableId"]),
                    Convert.ToInt32(row["TableNo"]),
                    Convert.ToInt32(row["Capacity"]),
                    "Available", // Default status
                    row["Location"].ToString()
                ));
            }
            return availableTables;
        }

       
    }
}
