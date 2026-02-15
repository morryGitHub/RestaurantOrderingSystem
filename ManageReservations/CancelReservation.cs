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
    public partial class FrmCancelReservation : Form
    {
        public FrmCancelReservation()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (rbCustName.Checked)
            {
                string nameCheck = Validation.IsNameValid(tbCustName.Text);
                if (nameCheck != "Valid")
                {
                    MessageBox.Show(nameCheck, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                string phoneCheck = Validation.IsPhoneValid(tbPhoneNum.Text);
                if (phoneCheck != "Valid")
                {
                    MessageBox.Show(phoneCheck, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            dgvMatchingReservation.Rows.Clear();

            dgvMatchingReservation.Rows.Add("Kolya", "+3538332", "12/12/2025" ,"12:00", "4", "12");
            dgvMatchingReservation.Rows.Add("Nick", "+3531254", "11/12/2025", "14:00", "2", "1");
            dgvMatchingReservation.Rows.Add("Artem", "+353044543", "12/04/2025", "16:00", "5", "2");;

        }

        private void rbCustName_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCustName.Checked)
            {
                tbCustName.ReadOnly = false;
                tbPhoneNum.ReadOnly = true;

                tbPhoneNum.Text = "";   
                tbCustName.Focus();
            }
        }


        private void rbPhone_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPhoneNum.Checked)
            {
                tbPhoneNum.ReadOnly = false;
                tbCustName.ReadOnly = true;

                tbCustName.Text = "";
                tbPhoneNum.Focus();
            }
        }


        private void tbCustName_TextChanged(object sender, EventArgs e)
        {

        }

     

        private void btnCancelReservation_Click(object sender, EventArgs e)
        {
            if (UserSession.ReservationAction == "Update")
            {
                string check = Validation.IsGridSelected(dgvMatchingReservation);

                if (check != "valid")
                {
                    MessageBox.Show(check, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataGridViewRow row = dgvMatchingReservation.SelectedRows[0];


                frmUpdateReservation updateForm = new frmUpdateReservation(row);
                updateForm.TopMost = true;
                updateForm.Show();

                this.Close();
            }
            else if (UserSession.ReservationAction == "Remove")
            {
                string check = Validation.IsGridSelected(dgvMatchingReservation);

                if (check != "valid")
                {
                    MessageBox.Show(check, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataGridViewRow row = dgvMatchingReservation.SelectedRows[0];

                string customerName = row.Cells["colName"].Value.ToString();
                string phone = row.Cells["Phone"].Value.ToString();
                string date = row.Cells["Date"].Value.ToString();
                string time = row.Cells["Time"].Value.ToString();
                string numberOfGuests = row.Cells["Guests"].Value.ToString();
                string table = row.Cells["Table"].Value.ToString();


                var confirm = MessageBox.Show(
                    $"Are you sure you want to remove this reservation?\n\n" +
                    $"Customer: {customerName}\nPhone: {phone}\nDate: {date}",
                    "Confirm Removal",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm != DialogResult.Yes)
                    return;

                MessageBox.Show("Reservation was successfully removed!",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                dgvMatchingReservation.Rows.Remove(row);
            }
        }

        private void tbPhoneNum_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
