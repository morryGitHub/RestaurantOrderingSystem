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
        }



        private void lblTableNo_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Table deletion cancelled.",
                "Cancelled",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            this.Close();
        }

        private void btnRemoveTable_Click(object sender, EventArgs e)
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

            Table.DeleteTable(selectedTable.TableNumber);

            this.Close();
        }

        private void cmbTableNo_SelectedIndexChanged(object sender, EventArgs e)
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

        private void frmRemoveTable_Load(object sender, EventArgs e)
        {

            LoadTables();

        }

        private void LoadTables()
        {
            cmbTableNo.Items.Clear();

            List<Table> tables = Table.GetAvailableTables();
            Console.WriteLine(tables.Count);

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
    }
}
