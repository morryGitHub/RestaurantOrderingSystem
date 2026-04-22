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
    public partial class FrmCancelOrder : Form
    {
        public FrmCancelOrder()
        {
            InitializeComponent();
            UIStyleHelper.ApplyDarkTheme(dgvOrderItems);
            UIStyleHelper.Apply;

        }

        private void frmCancelOrder_Load(object sender, EventArgs e)
        {
            FillActiveOrdersComboBox();
        }

        private void cmbOrders_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            dgvOrderItems.Rows.Clear();
            lblTotal.Text = "€{0.00}";

            if (cmbOrders.Text.Equals("Select the Order"))
            {
                btnCancel.Enabled = false;
                return;

            }

            btnCancel.Enabled = true;
            cmbOrders.Items.Remove("Select the Order");

            try
            {
                Order order = cmbOrders.SelectedItem as Order;
                OrderItem orderItem = new OrderItem(order);
                DataSet dsActive = orderItem.GetMenuItemsFromOrder();

                foreach (DataRow row in dsActive.Tables[0].Rows)
                {
                    string itemName = row["ItemName"].ToString();
                    decimal unitPrice = Convert.ToDecimal(row["UnitPrice"]);
                    int qty = Convert.ToInt32(row["Quantity"]);
                    decimal subtotal = unitPrice * qty;
                    int menuItemID = Convert.ToInt32(row["MenuItemID"]);


                    dgvOrderItems.Rows.Add(
                        itemName,
                        unitPrice.ToString("F2"),
                        qty,
                        subtotal.ToString("F2"),
                        menuItemID
                    );
                }

                lblTotal.Text = $"€{Validation.GetTotalAmount(dgvOrderItems):F2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading order items: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (cmbOrders.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an order to cancel.");
                return;
            }

            var order = cmbOrders.SelectedItem as Order;
            int orderID = order.ID;

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to cancel {orderID}?",
                "Confirm Cancellation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result != DialogResult.Yes)
                return;

            order.CancelOrder();


            MessageBox.Show(
                $"Order {orderID} was successfully cancelled.\nTable is now available.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void dgvOrderItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void FillActiveOrdersComboBox()
        {
            cmbOrders.Items.Clear();
            List<Order> orders = Order.LoadOrders();

            cmbOrders.Items.Add("Select the Order");
            cmbOrders.SelectedIndex = 0;

            foreach (Order order in orders)
            {
                cmbOrders.Items.Add(order);

            }
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
