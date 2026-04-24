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
            UIStyleHelper.ApplyRemoveButtonStyle(btnCancelOrder);
            UIStyleHelper.ApplyCancelButtonStyle(btnExit);

        }

        private void FrmCancelOrder_Load(object sender, EventArgs e)
        {
            FillActiveOrdersComboBox();
        }

        private void CmbOrders_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            dgvOrderItems.Rows.Clear();
            lblTotal.Text = "€{0.00}";


            if (!(cmbOrders.SelectedItem is Order selectedOrder))
            {
                return;
            }


            if (cmbOrders.Items.Contains("-- Select the Order --"))
            {
                cmbOrders.Items.Remove("-- Select the Order --");
            }

            btnCancelOrder.Enabled = true;

            try
            {
                OrderItem orderItem = new OrderItem(selectedOrder.Id);
                DataSet dsActive = orderItem.GetMenuItemsFromOrder("Active");

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
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (!(cmbOrders.SelectedItem is Order order))
            {
                MessageBox.Show("To get started, please select an order from the list.",
                         "Selection Required",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to cancel {order.Id}?",
                "Confirm Cancellation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result != DialogResult.Yes)
                return;

            try
            {

                order.CancelOrder();


                MessageBox.Show(
                    $"Order {order.Id} was successfully cancelled.\nTable is now available.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while cancelling the order: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void DgvOrderItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void FillActiveOrdersComboBox()
        {
            cmbOrders.Items.Clear();
            List<Order> orders = Order.LoadOrders();

          

            foreach (Order order in orders)
            {
                cmbOrders.Items.Add(order);

            }

            if(cmbOrders.Items.Count == 0)
            {
                cmbOrders.Items.Insert(0, "-- No Active Orders --");
                cmbOrders.SelectedIndex = 0;
                cmbOrders.Enabled = false;
                return; 
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
