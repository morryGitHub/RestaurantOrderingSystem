using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RestaurantOrderingSystem
{
    public partial class FrmRemoveTable : Form
    {
        public FrmRemoveTable()
        {
            InitializeComponent();
            UIStyleHelper.ApplyCancelButtonStyle(btnExit);
            UIStyleHelper.ApplyRemoveButtonStyle(btnRemoveTable);
        }



        private void LblTableNo_Click(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The table deletion process has been cancelled.",
                 "Operation Cancelled",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information);

            this.Close();
        }

        private void BtnRemoveTable_Click(object sender, EventArgs e)
        {
            Table selectedTable = (Table)cmbTableNo.SelectedItem;
            if (selectedTable == null)
            {
                return;
            }
            int tableNo = selectedTable.Number;

            if (cmbTableNo.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a table number from the list to continue.",
                 "Selection Required",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                $"Are you sure you want to delete Table #{tableNo}?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
            {
                MessageBox.Show("The table deletion process has been cancelled.",
                 "Operation Cancelled",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information);

                this.Close();
                return;
            }
            MessageBox.Show($"Table #{tableNo} has been deleted successfully.",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            Table tableToDelete = new Table { Number = tableNo };

            tableToDelete.DeleteTable();

            this.Close();
        }

        private void CmbTableNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(cmbTableNo.SelectedItem is Table selectedTable))
            {
                btnRemoveTable.Enabled = false;

                return;
            }


            if (cmbTableNo.Items.Contains("-- Select the Table --"))
            {
                cmbTableNo.Items.Remove("-- Select the Table --");
            }

           
            btnRemoveTable.Enabled = true;

            string location = selectedTable.Location;
            tbLocation.Text = location;
        }

        private void FrmRemoveTable_Load(object sender, EventArgs e)
        {
            LoadTables();

            var normal = new Font("Segoe UI", 10, FontStyle.Regular);

            lblTitle.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(30, 30, 30);


            groupBox1.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            groupBox1.Padding = new Padding(10);

            lblTableNo.Font = normal;
            lblTableNo.ForeColor = Color.FromArgb(60, 60, 60);
            lblLocation.Font = normal;
            lblLocation.ForeColor = Color.FromArgb(60, 60, 60);

            cmbTableNo.Font = normal;
            tbLocation.Font = normal;
            tbLocation.ReadOnly = true;
        }

        private void LoadTables()
        {
            try
            {
                cmbTableNo.Items.Clear();

                List<Table> tables = Table.GetAvailableTables();

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
                MessageBox.Show($"Error loading tables: {ex.Message}",
                                "Database Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void BackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
