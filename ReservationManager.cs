using System;
using System.Collections.Generic;
using System.Data;
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
                if (Validation.IsNameValid(name) != "Valid")
                {
                    MessageBox.Show("Error Name");
                    resInfo.Visible = true;
                    return;

                }
            }
            else
            {
                phone = tbPhoneNum.Text;
                if (Validation.IsPhoneValid(phone) != "Valid")
                {
                    MessageBox.Show("Error Phone");
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
                        string custName = row["CUSTOMERNAME"]?.ToString() ?? "";
                        string custPhone = row["CUSTOMERPHONE"]?.ToString() ?? "";
                        string date = row["RESERVATIONDATETIMESTART"]?.ToString() ?? "";
                        int numOfGuest = Convert.ToInt32(row["NUMBEROFGUESTS"]);
                        int tableNo = Convert.ToInt32(row["TableNo"]);
                        int tableID = Convert.ToInt32(row["TableID"]);
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
    }
}
