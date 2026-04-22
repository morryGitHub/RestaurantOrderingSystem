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
            dgvMatchingReservation.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            UIStyleHelper.ApplyCancelButtonStyle(btnCancel);


        }


        private void BtnSearch_Click_1(object sender, EventArgs e)
        {
            ReservationManager.GetReservations(dgvMatchingReservation, rbCustName, tbCustName, tbPhoneNum, lblResInfo);

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmFindReservation_Load(object sender, EventArgs e)
        {

            ApplyReservationDesign();
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


        private void TbPhoneNum_Click(object sender, EventArgs e)
        {
            rbPhoneNum.Checked = true;
            tbPhoneNum.ReadOnly = false;
            tbCustName.ReadOnly = true;


        }

        private void TbCustName_Click(object sender, EventArgs e)
        {
            rbCustName.Checked = true;
            tbPhoneNum.ReadOnly = true;
            tbCustName.ReadOnly = false;
        }

        private void RbCustName_CheckedChanged_1(object sender, EventArgs e)
        {
            tbCustName.Focus();
            tbPhoneNum.ReadOnly = true;
            tbCustName.ReadOnly = false;
        }

        private void RbPhoneNum_CheckedChanged(object sender, EventArgs e)
        {
            tbPhoneNum.Focus();
            tbPhoneNum.ReadOnly = false;
            tbCustName.ReadOnly = true;
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            try
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
                            Table tableObj = new Table() { TableId = tableID };
                            this.Hide();
                            this.Close();
                            FrmNewOrder newOrder = new FrmNewOrder(tableObj);
                            newOrder.ShowDialog();
                            
                            break;

                        case ("Update"):
                            FrmUpdateReservation frmUpdateReservation = new FrmUpdateReservation(resID, tableID);

                            if (frmUpdateReservation.ShowDialog() == DialogResult.OK)
                            {
                                ReservationManager.GetReservations(dgvMatchingReservation, rbCustName, tbCustName, tbPhoneNum, lblResInfo);
                            }
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
            catch (Exception ex)
            {
                MessageBox.Show($"Error cancelling reservation: {ex.Message}");
            }
        }

        private void BackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void ApplyReservationDesign()
        {
            var normalFont = new Font("Segoe UI", 10, FontStyle.Regular);
            var boldFont = new Font("Segoe UI", 10, FontStyle.Bold);

            this.BackColor = Color.White;

            lblTitle.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(30, 30, 30);

            grpSearching.Font = boldFont;
            grpSearching.ForeColor = Color.FromArgb(50, 50, 50);

            rbCustName.Font = normalFont;
            rbPhoneNum.Font = normalFont;
          

            tbCustName.Font = normalFont;
            tbPhoneNum.Font = normalFont;
           
           

         
        }


    }
}
