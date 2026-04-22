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
            MessageBox.Show(
                "Table deletion cancelled.",
                "Cancelled",
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
            int tableId = selectedTable.TableNumber;

            if (cmbTableNo.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a table number.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            var confirm = MessageBox.Show(
                $"Are you sure you want to delete Table #{tableId}?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
            {
                MessageBox.Show(
                    "Table deletion was cancelled.",
                    "Cancelled",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.Close();
                return;
            }

            MessageBox.Show(
                $"Table #{tableId} was deleted successfully!",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            Table tableToDelete = new Table { TableNumber = tableId };

            tableToDelete.DeleteTable();

            this.Close();
        }

        private void CmbTableNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTableNo.SelectedIndex == 0)
            {
                // placeholder selected → invalid
                btnRemoveTable.Enabled = false;
                return;
            }

            cmbTableNo.Items.Remove("Select the Table");
            btnRemoveTable.Enabled = true;
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

            cmbTableNo.Font = normal;
     
          
        }

        private void LoadTables()
        {
            try
            {
                cmbTableNo.Items.Clear();

                List<Table> tables = Table.GetAvailableTables();

                if (tables.Count == 0)
                {
                    cmbTableNo.Items.Add("No Tables Available");
                    cmbTableNo.SelectedIndex = 0;
                    cmbTableNo.Enabled = false;
                    return;
                }

                cmbTableNo.Items.Add("Select the Table");
                cmbTableNo.SelectedIndex = 0;

                foreach (Table table in tables)
                {
                    cmbTableNo.Items.Add(table);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading tables: {ex.Message}",
                                "Database Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
