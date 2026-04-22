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


        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void UpdateTableForm_Load(object sender, EventArgs e)
        {
            LoadTables();

            var normal = new Font("Segoe UI", 10, FontStyle.Regular);

            // ===== FORM BACKGROUND =====
            this.BackColor = Color.White;
            // ===== TITLE =====
            lblTitle.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(30, 30, 30);

            // ===== GROUPBOX (CARD STYLE) =====
            this.BackColor = Color.White;

            groupBox1.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            groupBox1.ForeColor = Color.FromArgb(50, 50, 50);
            groupBox1.Padding = new Padding(10);

            // ===== LABELS =====
            lblTabeNo.Font = normal;
            lblTabeNo.ForeColor = Color.FromArgb(60, 60, 60);

            lblCapacity.Font = normal;
            lblCapacity.ForeColor = Color.FromArgb(60, 60, 60);

            lblStatus.Font = normal;
            lblStatus.ForeColor = Color.FromArgb(60, 60, 60);

            // ===== INPUTS =====
            cmbTableNo.Font = normal;
            cmbTableNo.BackColor = Color.White;

            numSeats.Font = normal;
            numSeats.BackColor = Color.White;

            cmbStatus.Font = normal;
            cmbStatus.BackColor = Color.White;

            tbLocation.Font = normal;
            tbLocation.BackColor  = Color.White;

            // ===== BUTTONS =====

            // Primary (Update)


            // Exit (secondary)
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.BackColor = Color.LightGray;
            btnExit.ForeColor = Color.Black;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.Font = normal;
            btnExit.FlatAppearance.MouseOverBackColor = Color.Gray;

            // ===== INITIAL STATE =====
            btnUpdateTable.Enabled = false;
            numSeats.Enabled = false;
            cmbStatus.Enabled = false;
        }



        private void BtnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Table updating cancelled.",
                "Cancelled",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            this.Close();
        }

        private void CmbTableNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTableNo.SelectedIndex == 0)
            {
                // placeholder selected → invalid
                btnUpdateTable.Enabled = false;
                numSeats.Enabled = false;
                cmbStatus.Enabled = false;
                return;
            }

            btnUpdateTable.Enabled = true;
            numSeats.Enabled = true;
            cmbStatus.Enabled = true;

            Table selectedTable = cmbTableNo.SelectedItem as Table;
            _ = selectedTable.TableId;
            string status = selectedTable.Status;
            int seats = selectedTable.Capacity;
            string location = selectedTable.Location;

            cmbStatus.SelectedItem = status;
            numSeats.Value = seats;
            tbLocation.Text = location;
        }

        private void btnUpdateTable_Click(object sender, EventArgs e)
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
            int tableNo = selectedTable.TableNumber;
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

            //LoadTables();

            this.Close();
        }

        private void numSeats_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadTables()
        {

            try
            {
                cmbTableNo.Items.Clear();

                List<Table> tables = Table.GetTables();

                if (tables.Count == 0)
                {
                    cmbTableNo.Items.Add("No Tables Available");
                    cmbTableNo.SelectedIndex = 0;
                    cmbTableNo.Enabled = false;
                    return;
                }

                cmbTableNo.Items.Add("Select the table");
                cmbTableNo.SelectedIndex = 0;


                foreach (Table table in tables)
                {
                    cmbTableNo.Items.Add(table);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load tables: {ex.Message}", "Database Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                cmbTableNo.Enabled = false;
            }
        }

        private void lblCapacity_Click(object sender, EventArgs e)
        {

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
