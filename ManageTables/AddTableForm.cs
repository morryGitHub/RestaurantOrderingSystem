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
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            try
            {
                string seatingCheck = Validation.IsSeatingCapacityValid(numericSeatingCap.Value);

                if (seatingCheck != "Valid")
                {
                    MessageBox.Show(seatingCheck, "Validation Error");
                    return;
                }


                Table table = new Table(Convert.ToInt16(tableNum.Text), (int)numericSeatingCap.Value);
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


        private void btnCancel_Click(object sender, EventArgs e)
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
            // Existing logic
            int freeNo = Table.GetLastTableID();
            tableNum.Text = freeNo.ToString();

            // ===== DESIGN MATCH (same as FrmPrintRevenue) =====

            var normal = new Font("Segoe UI", 10, FontStyle.Regular);

            this.BackColor = Color.White;

            // Example: Title label (if you have one like lblTitle)
            lblTitle.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(30, 30, 30);
            groupBox1.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            groupBox1.ForeColor = Color.FromArgb(50, 50, 50);

            // Labels
            lblTableNo.Font = normal;
            lblCapacity.Font = normal;

            // TextBox styling
            tableNum.Font = normal;
            tableNum.BorderStyle = BorderStyle.FixedSingle;

            // NumericUpDown styling
            numericSeatingCap.Font = normal;

            // ===== Buttons =====

            // Add Button (same blue style)
            btnAddTable.FlatStyle = FlatStyle.Flat;
            btnAddTable.BackColor = Color.FromArgb(0, 120, 215);
            btnAddTable.ForeColor = Color.White;
            btnAddTable.FlatAppearance.BorderSize = 0;
            btnAddTable.Font = normal;

            // Cancel Button (neutral style)
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.BackColor = Color.LightGray;
            btnCancel.ForeColor = Color.Black;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.Font = normal;
        }

        private void tableNum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
