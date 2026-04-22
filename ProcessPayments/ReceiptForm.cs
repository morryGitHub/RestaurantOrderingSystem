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
    public partial class FrmReceipt : Form
    {

        internal string OrderNumber { get; set ; }
        internal string PaymentMethod { get; set; }
        internal decimal Total { get; set; }
        internal DataGridView Items { get; set; }

        public FrmReceipt(string orderNumber, string paymentMethod, decimal total, DataGridView items)
        {
            InitializeComponent();
            OrderNumber = orderNumber;
            PaymentMethod = paymentMethod;
            Total = total;
            Items = items;
            UIStyleHelper.ApplyPrimaryButtonStyle(btnPrint);

        }

        private void ReceiptForm_Load(object sender, EventArgs e)
        {
            rtbReceipt.ReadOnly = true;
            rtbReceipt.Font = new Font("Consolas", 11);

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("=========== RECEIPT ===========");
            sb.AppendLine($"Order: {OrderNumber}");
            sb.AppendLine($"Date: {DateTime.Now}");
            sb.AppendLine("--------------------------------");

            sb.AppendLine("Item                  Qty   Price");

            foreach (DataGridViewRow row in Items.Rows)
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
            sb.AppendLine($"TOTAL: €{Total:F2}");
            sb.AppendLine($"Payment Method: {PaymentMethod}");
            sb.AppendLine("================================");

            sb.AppendLine("\nThank you for your visit!");

            rtbReceipt.Text = sb.ToString();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Receipt sent to printer (prototype).",
                            "Print",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }


        private void BtnPrint_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Receipt sent to printer (prototype).",
                            "Print",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            this.Close();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
