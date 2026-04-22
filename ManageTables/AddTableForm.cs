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
    public partial class FrmAddTable : Form
    {
        public FrmAddTable()
        {
            InitializeComponent();
            UIStyleHelper.ApplyPrimaryButtonStyle(btnAddTable);
            UIStyleHelper.ApplyCancelButtonStyle(btnCancel);

        }

        private void BtnAddTable_Click(object sender, EventArgs e)
        {
            try
            {
                string seatingCheck = Validation.IsSeatingCapacityValid(numericSeatingCap.Value);
                string location = tbLocation.Text;

                if (seatingCheck != "Valid")
                {
                    MessageBox.Show(seatingCheck, "Validation Error");
                    return;
                }


                if (string.IsNullOrEmpty(location))
                {
                    MessageBox.Show("Please enter a table location.",
                                    "Validation Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return;
                }


                Table table = new Table(Convert.ToInt16(tableNum.Text), (int)numericSeatingCap.Value, tbLocation.Text);
                table.AddTable();

                MessageBox.Show(
                    $"Table {tableNum.Text} has been added!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to add table. It might already exist or the database is offline." +
                    "\n\nDetails: " + ex.Message,
                    "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BtnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Table creation was cancelled.",
                "Cancelled",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            this.Close();
        }
        private void AddTableForm_Load(object sender, EventArgs e)
        {
            try
            {
                int freeNo = Table.GetLastTableID();
                tableNum.Text = freeNo.ToString();

                var normal = new Font("Segoe UI", 10, FontStyle.Regular);

                this.BackColor = Color.White;

                lblTitle.Font = new Font("Segoe UI", 16, FontStyle.Bold);
                lblTitle.ForeColor = Color.FromArgb(30, 30, 30);
                groupBox1.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                groupBox1.ForeColor = Color.FromArgb(50, 50, 50);

                lblTableNo.Font = normal;
                lblCapacity.Font = normal;
                lblLocation.Font = normal;  

                tableNum.Font = normal;
                tableNum.BorderStyle = BorderStyle.FixedSingle;
                tableNum.ReadOnly = true;
                tableNum.BackColor = Color.WhiteSmoke;

                numericSeatingCap.Font = normal;
                tbLocation.Font = normal;




            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load form. The database might be offline." +
                    "\n\nDetails: " + ex.Message,
                    "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
