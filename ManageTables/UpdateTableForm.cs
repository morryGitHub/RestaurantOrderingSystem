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
    public partial class FrmUpdateTable: Form
    {
        public FrmUpdateTable()
        {
            InitializeComponent();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void UpdateTableForm_Load(object sender, EventArgs e)
        {
            LoadTables();
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

            cmbStatus.SelectedItem = status;
            numSeats.Value = seats;

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

            string seatingCheck = Validation.IsSeatingCapacityValid(numSeats.Value);
            if (seatingCheck != "valid")
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

            Table table = new Table
            {
                Capacity = seatingCapacity,
                Status = status,
                TableNumber = tableNo
            };

            table.UpdateTable();


            MessageBox.Show(
                $"Table {tableNo} was successfully updated!\n\n" +
                $"New seating capacity: {seatingCapacity}\n" +
                $"New status: {status}",
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


    }
}
