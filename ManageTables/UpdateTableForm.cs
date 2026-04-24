using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RestaurantOrderingSystem
{
    public partial class FrmUpdateTable : Form
    {
        public FrmUpdateTable()
        {
            InitializeComponent();
            UIStyleHelper.ApplyPrimaryButtonStyle(btnUpdateTable);
            UIStyleHelper.ApplyCancelButtonStyle(btnExit);
        }
   

        private void UpdateTableForm_Load(object sender, EventArgs e)
        {
            LoadTables();

            var normal = new Font("Segoe UI", 10, FontStyle.Regular);

            this.BackColor = Color.White;
            lblTitle.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(30, 30, 30);

            this.BackColor = Color.White;

            groupBox1.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            groupBox1.ForeColor = Color.FromArgb(50, 50, 50);
            groupBox1.Padding = new Padding(10);

            lblTabeNo.Font = normal;
            lblTabeNo.ForeColor = Color.FromArgb(60, 60, 60);

            lblCapacity.Font = normal;
            lblCapacity.ForeColor = Color.FromArgb(60, 60, 60);

            lblStatus.Font = normal;
            lblStatus.ForeColor = Color.FromArgb(60, 60, 60);

            cmbTableNo.Font = normal;
            cmbTableNo.BackColor = Color.White;

            numSeats.Font = normal;
            numSeats.BackColor = Color.White;

            cmbStatus.Font = normal;
            cmbStatus.BackColor = Color.White;

            tbLocation.Font = normal;
            tbLocation.BackColor = Color.White;

            btnUpdateTable.Enabled = false;
            numSeats.Enabled = false;
            cmbStatus.Enabled = false;
        }



        private void BtnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The table update process has been cancelled.",
                 "Operation Cancelled",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information);

            this.Close();
        }

        private void CmbTableNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(cmbTableNo.SelectedItem is Table selectedTable))
            {
                btnUpdateTable.Enabled = false;
                numSeats.Enabled = false;
                cmbStatus.Enabled = false;
                tbLocation.Enabled = false;
                return;
            }


            if (cmbTableNo.Items.Contains("-- Select the Table --"))
            {
                cmbTableNo.Items.Remove("-- Select the Table --");
            }

            btnUpdateTable.Enabled = true;
            numSeats.Enabled = true;
            cmbStatus.Enabled = true;
            tbLocation.Enabled = true;

           
            _ = selectedTable.TableId;
            string status = selectedTable.Status;
            int seats = selectedTable.Capacity;
            string location = selectedTable.Location;

            cmbStatus.SelectedItem = status;
            numSeats.Value = seats;
            tbLocation.Text = location;
        }

        private void BtnUpdateTable_Click(object sender, EventArgs e)
        {
            if (cmbTableNo.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a table number.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
            Table selectedTable = cmbTableNo.SelectedItem as Table;
            int tableNo = selectedTable.Number;
            int seatingCapacity = (int)numSeats.Value;
            string status = cmbStatus.Text;
            string location = tbLocation.Text;

            string seatingCheck = Validation.IsSeatingCapacityValid(numSeats.Value);
            if (seatingCheck != "Valid")
            {
                MessageBox.Show(seatingCheck,
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(status))
            {
                MessageBox.Show("Please select a table status.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
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

            Table table = new Table(seatingCapacity, tableNo, status, location);


            table.UpdateTable();


            MessageBox.Show(
                $"Table {tableNo} was successfully updated!\n\n" +
                $"New seating capacity: {seatingCapacity}\n" +
                $"New status: {status}\n" +
                $"New loaction: {location}\n",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            this.Close();
        }


        private void LoadTables()
        {

            try
            {
                cmbTableNo.Items.Clear();

                List<Table> tables = Table.GetTables();

                if (tables.Count == 0)
                {
                    cmbTableNo.Items.Add("-- No Tables Available --");
                    cmbTableNo.SelectedIndex = 0;
                    cmbTableNo.Enabled = false;
                    return;
                }

                foreach (Table table in tables)
                {
                    cmbTableNo.Items.Add(table);
                }

                cmbTableNo.Items.Insert(0, "-- Select the Table --");
                cmbTableNo.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load tables: {ex.Message}", "Database Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                cmbTableNo.Enabled = false;
            }
        }


        private void BackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
