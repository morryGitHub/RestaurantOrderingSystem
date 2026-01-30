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
    public partial class frmRemoveTable : Form
    {
        public frmRemoveTable()
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
            if (selectedTable == null) {
                throw new Exception("Table Not Found");
            }
            int tableId = selectedTable.TableId;

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
                $"Table {tableId} was deleted successfully!",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            Table.DeleteTable(selectedTable.TableNumber);

            this.Close();
        }

        private void cmbTableNo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmRemoveTable_Load(object sender, EventArgs e)
        {

            DataSet ds = Table.GetAllTables();
            Console.WriteLine(ds);

            cmbTableNo.Items.Clear();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                int tableNo = Convert.ToInt32(ds.Tables[0].Rows[i]["TABLE_NO"]);
                int seats = Convert.ToInt32(ds.Tables[0].Rows[i]["CAPACITY"]);
                string status = ds.Tables[0].Rows[i]["STATUS"].ToString();

                cmbTableNo.Items.Add(
                    new Table(tableNo, seats, status)
                );
            }

        }
    }
}
