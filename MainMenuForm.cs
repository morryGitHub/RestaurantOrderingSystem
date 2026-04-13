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
    public partial class FrmMainMenu : Form
    {
        public FrmMainMenu()
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

        private void AddOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNewOrder newOrder = new FrmNewOrder();
            newOrder.ShowDialog();
        }

        private void AddReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddReservation form = new FrmAddReservation();
            form.ShowDialog();


        }

        private void UpdateReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserSession.ReservationAction = "Update";
            FrmFindReservation form = new FrmFindReservation();
            form.ShowDialog();
        }

        private void RemoveReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserSession.ReservationAction = "Remove";
            FrmFindReservation form = new FrmFindReservation();
            form.ShowDialog();

        }

        private void AddTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddTable addTable = new FrmAddTable();
            addTable.ShowDialog();

        }

        private void UpdateTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUpdateTable updateTable = new FrmUpdateTable();
            updateTable.ShowDialog();
        }

        private void RemoveTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRemoveTable removeTable = new FrmRemoveTable();
            removeTable.ShowDialog();
        }

        private void UpdateExistingOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUpdateOrder frmUpdate = new FrmUpdateOrder();
            frmUpdate.ShowDialog();
        }

        private void CancelOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCancelOrder frmCancelOrder = new FrmCancelOrder();
            frmCancelOrder.ShowDialog();
        }

        private void MakePaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMakePayment frmMakePayment = new FrmMakePayment();
            frmMakePayment.ShowDialog();
        }

        private void ReprintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRefundPayment frmRefund = new FrmRefundPayment();
            frmRefund.ShowDialog();
        }

        private void ReprintReceiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReprintReceipt reprintReceipt = new FrmReprintReceipt();
            reprintReceipt.ShowDialog();
        }

        private void PrintYearlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPrintRevenue printRevenue = new FrmPrintRevenue();
            printRevenue.ShowDialog();
        }

        private void DisplayStatisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStatistics statisticsForm = new FrmStatistics();
            statisticsForm.ShowDialog();
        }

        private void StatisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                FrmLogging frmLogging = new FrmLogging();
                this.Hide();
                frmLogging.ShowDialog();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FindReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserSession.ReservationAction = "Find";
            FrmFindReservation frmFindReservation = new FrmFindReservation();
            frmFindReservation.ShowDialog();

        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to close this page?",
                "Confirm Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }
    }
}
