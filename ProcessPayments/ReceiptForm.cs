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
    public partial class frmReceipt : Form
    {
        private string _orderNumber;
        private string _paymentMethod;
        private decimal _total;
        private DataGridView _items;

        public frmReceipt(string orderNumber, string paymentMethod, decimal total, DataGridView items)
        {
            InitializeComponent();
            _orderNumber = orderNumber;
            _paymentMethod = paymentMethod;
            _total = total;
            _items = items;
        }

        private void ReceiptForm_Load(object sender, EventArgs e)
        {
            rtbReceipt.ReadOnly = true;
            rtbReceipt.Font = new Font("Consolas", 11);

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("=========== RECEIPT ===========");
            sb.AppendLine($"Order: {_orderNumber}");
            sb.AppendLine($"Date: {DateTime.Now}");
            sb.AppendLine("--------------------------------");

            sb.AppendLine("Item                  Qty   Price");

            foreach (DataGridViewRow row in _items.Rows)
            {
                string item = row.Cells[0].Value.ToString();
                string price = row.Cells[1].Value.ToString();
                string qty = row.Cells[2].Value.ToString();

                decimal priceDec = Decimal.Parse(price);
                decimal qtyDec = Decimal.Parse(qty);
                decimal subTotal = priceDec * qtyDec;



                sb.AppendLine($"{item,-20} {qty,3}   €{subTotal}");
            }

            sb.AppendLine("--------------------------------");
            sb.AppendLine($"TOTAL: €{_total:F2}");
            sb.AppendLine($"Payment Method: {_paymentMethod}");
            sb.AppendLine("================================");

            sb.AppendLine("\nThank you for your visit!");

            rtbReceipt.Text = sb.ToString();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Receipt sent to printer (prototype).",
                            "Print",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }


        private void btnPrint_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Receipt sent to printer (prototype).",
                            "Print",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            this.Close();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
