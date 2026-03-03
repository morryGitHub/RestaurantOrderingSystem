using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantOrderingSystem
{
    public partial class FrmReprintReceipt : Form
    {
        public FrmReprintReceipt()
        {
            InitializeComponent();
        }


      

        private void ReprintReceipt_Load(object sender, EventArgs e)
        {
            var normal = new Font("Segoe UI", 10, FontStyle.Regular);

            dgvOrderDetails.Font = normal;
            dgvOrderDetails.DefaultCellStyle.Font = normal;
            dgvOrderDetails.RowsDefaultCellStyle.Font = normal;
            dgvOrderDetails.AlternatingRowsDefaultCellStyle.Font = normal;

            dgvOrderDetails.ColumnHeadersDefaultCellStyle.Font = normal;
            dgvOrderDetails.RowHeadersDefaultCellStyle.Font = normal;

            dgvOrderDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrderDetails.ReadOnly = true;
            dgvOrderDetails.MultiSelect = false;

            dgvOrderDetails.ClearSelection();
            FillPaidPaymentsComboBox();
        }

        private void dgvPayments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

      

    

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnRefund_Click(object sender, EventArgs e)
        {
            Order order = cmbOrders.SelectedItem as Order;
            if (order == null) return;

            string orderName = $"Table {order.Table.TableNumber} — Order #{order.ID}";

            string paymentMethod = Payment.GetPaymentMethodByOrder(order.ID) ?? "Unspecified";

            DataSet dsItems = OrderItem.GetMenuItemsFromOrder(order.ID, "Completed");
            decimal total = 0;
            foreach (DataRow row in dsItems.Tables[0].Rows)
            {
                decimal unitPrice = Convert.ToDecimal(row["UnitPrice"]);
                int qty = Convert.ToInt32(row["Quantity"]);
                total += unitPrice * qty;
            }

            FrmReceipt receipt = new FrmReceipt(orderName, paymentMethod, total, dgvOrderDetails);
            receipt.ShowDialog();
        }



        public void FillPaidPaymentsComboBox()
        {
            List<Order> orders = Payment.LoadPaidOrders();

            cmbOrders.Items.Clear();

            foreach (Order order in orders)
            {
                cmbOrders.Items.Add(order);
            }


        }

        private void cmbOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvOrderDetails.Rows.Clear();
            lblTotal.Text = "€0.00";

            if (cmbOrders.Text.Equals("Select the Order"))
            {
                return;
            }

            btnCancel.Enabled = true;
            cmbOrders.Items.Remove("Select the Order");

            Order order = cmbOrders.SelectedItem as Order;

            DataSet dsCompleted = OrderItem.GetMenuItemsFromOrder(order.ID, "Completed");

            foreach (DataRow row in dsCompleted.Tables[0].Rows)
            {
                string itemName = row["ItemName"].ToString();
                decimal unitPrice = Convert.ToDecimal(row["UnitPrice"]);
                int qty = Convert.ToInt32(row["Quantity"]);
                decimal subtotal = unitPrice * qty;
                int menuItemID = Convert.ToInt32(row["MenuItemID"]);


                dgvOrderDetails.Rows.Add(
                    itemName,
                    unitPrice.ToString("F2"),
                    qty,
                    subtotal.ToString("F2"),
                    menuItemID
                );
            }

            Validation.UpdateTotal(dgvOrderDetails, lblTotal);

        }
    }
}
