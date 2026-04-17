using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantOrderingSystem
{
    public partial class FrmFindReservation : Form
    {
        public FrmFindReservation()
        {
            InitializeComponent();
            UIStyleHelper.ApplyDarkTheme(dgvMatchingReservation);
            UIStyleHelper.ApplyPrimaryButtonStyle(btnNext);
            UIStyleHelper.ApplyPrimaryButtonStyle(btnSearch);


        }
        private void dgvMatchingReservation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            dgvMatchingReservation.Rows.Clear();
            dgvMatchingReservation.Visible = true;

            string phone = null;
            string name = null;

            if (rbCustName.Checked)
            {
                name = tbCustName.Text;
                if (Validation.IsNameValid(name) != "Valid")
                {
                    MessageBox.Show("Error Name");
                    return;
                }
            }
            else
            {
                phone = tbPhoneNum.Text;
                if (Validation.IsPhoneValid(phone) != "Valid")
                {
                    MessageBox.Show("Error Phone");
                    return;
                }
            }

            DataSet ds = Reservation.GetReservationDetails(phone, name);
            if (ds.Tables[0].Rows.Count == 0)
            {
                dgvMatchingReservation.Visible = false;
            }
            if (ds != null)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    string custName = Convert.ToString(row["CUSTOMERNAME"]);
                    string custPhone = Convert.ToString(row["CUSTOMERPHONE"]);
                    string date = Convert.ToString(row["RESERVATIONDATETIMESTART"]);
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





        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmFindReservation_Load(object sender, EventArgs e)
        {
            tbPhoneNum.ReadOnly = true;

            if (UserSession.ReservationAction == "Update")
            {
                btnNext.Text = "Update Reservation";
                this.Text = "Update Reservation";
            }
            else if (UserSession.ReservationAction == "Remove")
            {
                btnNext.Text = "Cancel Reservation";
                this.Text = "Cancel Reservation";

            }
            else
            {
                btnNext.Text = "Create New Order";
                this.Text = "Find Reservation";

            }


        }

        private void tbPhoneNum_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void tbPhoneNum_Click(object sender, EventArgs e)
        {
            rbPhoneNum.Checked = true;
            tbPhoneNum.ReadOnly = false;
            tbCustName.ReadOnly = true;


        }

        private void tbCustName_Click(object sender, EventArgs e)
        {
            rbCustName.Checked = true;
            tbPhoneNum.ReadOnly = true;
            tbCustName.ReadOnly = false;
        }

        private void rbCustName_CheckedChanged_1(object sender, EventArgs e)
        {
            tbCustName.Focus();
            tbPhoneNum.ReadOnly = true;
            tbCustName.ReadOnly = false;
        }

        private void rbPhoneNum_CheckedChanged(object sender, EventArgs e)
        {
            tbPhoneNum.Focus();
            tbPhoneNum.ReadOnly = false;
            tbCustName.ReadOnly = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            DataGridViewRow row = dgvMatchingReservation.SelectedRows[0];
            string nextPage = UserSession.ReservationAction;


            if (row != null)
            {
                int tableID = Convert.ToInt32(row.Cells["TableID"].Value);
                int resID = Convert.ToInt32(row.Cells["ResID"].Value);
                switch (nextPage)
                {

                    case ("Find"):
                        FrmNewOrder newOrder = new FrmNewOrder(tableID);
                        newOrder.ShowDialog();
                        break;

                    case ("Update"):
                        ;
                        FrmUpdateReservation frmUpdateReservation = new FrmUpdateReservation(resID, tableID);
                        frmUpdateReservation.ShowDialog();
                        break;

                    case ("Remove"):
                        Reservation reservation = new Reservation(resID);
                        reservation.DeleteReservation();
                        MessageBox.Show("Reservation was succesfully cancelled");
                        this.Close();
                        break;
                }

            }


        }
    }
}
