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
    public partial class FrmRefundPayment : Form
    {
        public FrmRefundPayment()
        {
            InitializeComponent();
            UIStyleHelper.ApplyDarkTheme(dgvPayments);
            UIStyleHelper.ApplyPrimaryButtonStyle(btnRefund);
            UIStyleHelper.ApplyCancelButtonStyle(btnCancel);


        }



        private void BtnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Refund process has been cancelled. No changes were made.",
                            "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }


        private void FrmRefundPayment_Load(object sender, EventArgs e)
        {
            FillPaidPaymentsComboBox();
        }


        private void CmbOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvPayments.Rows.Clear();

            if (!(cmbOrders.SelectedItem is Order selectedOrder))
            {
                btnRefund.Enabled = false;
                return;
            }

            btnRefund.Enabled = true;

            if (cmbOrders.Items.Contains("-- Select the Order --"))
            {
                cmbOrders.Items.Remove("-- Select the Order --");
            }


            try
            {
                DataSet ds = Payment.GetCompletedOrderDetails(selectedOrder.Id);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int paymentID = Convert.ToInt32(row["paymentID"]);
                    string methodType = row["methodType"].ToString();
                    decimal amount = Convert.ToDecimal(row["amount"]);
                    DateTime paymentDate = Convert.ToDateTime(row["paymentDate"]);


                    dgvPayments.Rows.Add(
                            paymentID,
                            paymentDate.ToString("dd-MM-yyyy HH:mm"),
                            methodType,
                            amount.ToString("F2")

                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading payments: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRefund_Click(object sender, EventArgs e)
        {
            if (cmbOrders.SelectedIndex == -1)
            {
                MessageBox.Show("To get started, please select an order from the list.",
                                "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dgvPayments.SelectedRows.Count == 0)
            {
                MessageBox.Show("We couldn't find a payment to process. Please click on a specific payment in the list to refund it.",
                                "Refund Criteria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                int paymentID = Convert.ToInt32(dgvPayments.SelectedRows[0].Cells["TableId"].Value);
                string amount = dgvPayments.SelectedRows[0].Cells["Amount"].Value.ToString();

                Payment.RefundPayment(paymentID);

                MessageBox.Show(
                    $"Refund processed successfully.\n" +
                    $"Payment TableId: {paymentID}\n" +
                    $"Refund Amount: €{amount:F2}",
                    "Refund Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while processing the refund: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvPayments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvPayments.ClearSelection();
        }

        public void FillPaidPaymentsComboBox()
        {

            cmbOrders.Items.Clear();
            List<Order> orders = Payment.LoadPaidOrders();

            foreach (Order order in orders)
            {
                cmbOrders.Items.Add(order);
            }

            if (cmbOrders.Items.Count == 0)
            {
                cmbOrders.Items.Add("-- No paid orders --");
                cmbOrders.SelectedIndex = 0;
                cmbOrders.Enabled = false;
            }


            cmbOrders.Items.Insert(0, "-- Select the Order --");
            cmbOrders.SelectedIndex = 0;


        }

        private void BackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
