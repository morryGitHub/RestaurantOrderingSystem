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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            if (UserSession.UserType == "Waiter")
            {
                statisticsToolStripMenuItem.Enabled = false;
                tablesToolStripMenuItem.Enabled = false;
                reservationToolStripMenuItem.Enabled = false; 
            }
        }

        private void addOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewOrder newOrder = new frmNewOrder();
            newOrder.ShowDialog();
        }

        private void addReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddReservation form = new frmAddReservation();
            form.ShowDialog();


        }

        private void updateReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserSession.ReservationAction = "Update";
            frmFindReservation form = new frmFindReservation();
            form.ShowDialog();
        }

        private void removeReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserSession.ReservationAction = "Remove";
            frmFindReservation form = new frmFindReservation();
            form.ShowDialog();

        }

        private void addTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTableForm addTable = new AddTableForm();
            addTable.ShowDialog();

        }

        private void updateTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateTable updateTable = new frmUpdateTable();
            updateTable.ShowDialog();
        }

        private void removeTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRemoveTable removeTable = new frmRemoveTable();
            removeTable.ShowDialog();
        }

        private void updateExistingOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateOrder frmUpdate = new frmUpdateOrder();
            frmUpdate.ShowDialog();
        }

        private void cancelOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCancelOrder frmCancelOrder = new frmCancelOrder();
            frmCancelOrder.ShowDialog();
        }

        private void makePaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMakePayment frmMakePayment = new frmMakePayment();
            frmMakePayment.ShowDialog();
        }

        private void reprintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRefundPayment frmRefund = new frmRefundPayment();
            frmRefund.ShowDialog();
        }

        private void reprintReceiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReprintReceipt reprintReceipt = new frmReprintReceipt();
            reprintReceipt.ShowDialog();
        }

        private void printYearlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrintRevenue printRevenue = new frmPrintRevenue();
            printRevenue.ShowDialog();
        }

        private void displayStatisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStatistics statisticsForm = new frmStatistics();
            statisticsForm.ShowDialog();
        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
