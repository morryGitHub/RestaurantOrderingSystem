using Oracle.ManagedDataAccess.Client;
using RestaurantOrderingSystem.OracleDatabase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantOrderingSystem
{
    internal class Payment
    {

        internal Order Order { get; set; }
        public decimal Amount { get; set; }
        public string MethodType { get; set; }
        public string PaymentDate { get; set; }

        public Payment(Order order, decimal amount, string methodType, string paymentDate)
        {
            Order = order;
            Amount = amount;
            MethodType = methodType;
            PaymentDate = paymentDate;
        }

        public Payment(Order order)
        {
            Order = order;
        }

        public string DisplayOrders()
        {
            return $"TableNo #{Order.Table.Number} — Order {Order.Id}";
        }

        public void MakePayment()
        {
            try
            {
                string sql = $@"
                    BEGIN 

                        INSERT INTO PAYMENTS(orderID, amount, methodType, paymentDate)
                        VALUES({Order.Id},{Amount},'{MethodType}',TO_DATE('{PaymentDate}', 'DD-MM-YYYY HH24:MI'));

                        UPDATE ORDERS
                        SET STATUS = 'Completed'
                        WHERE OrderID = {Order.Id};
                    
                    END;
                ";

                Database.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                throw new Exception($"[Payment.MakePayment] Transaction failed for Order #{Order.Id}. " +
                            $"\nAmount: {Amount} \nMessage: {ex.Message}");
            }
        }

        public static DataSet GetPaidPayments()
        {
            try
            {
                string sql = @"
                        SELECT 
                            p.orderID,
                            t.tableID,
                            t.tableNo
                        FROM payments p
                        JOIN orders o
                            ON p.orderID = o.orderID
                        JOIN tablesinfo t
                            ON o.tableID = t.tableID
                        WHERE p.status = 'Paid'";

                return Database.ExecuteMultiRowQuery(sql);
            }
            catch (Exception ex)
            {
                throw new Exception($"[Payment.GetPaidPayments] Failed to load list. \nMessage: {ex.Message}");
            }
        }

        public static string GetPaymentMethodByOrder(int orderID)
        {
            try
            {
                string sql = $@"
                    SELECT p.MethodType
                    FROM Payments p
                    WHERE p.OrderID = {orderID}
                    AND p.Status = 'Paid'";

                OracleDataReader reader = Database.ExecuteSingleRowQuery(sql);

                if (reader != null)
                {
                    if (reader.Read())
                    {
                        if (!reader.IsDBNull(0))
                        {
                            string status = reader.GetString(0);
                            reader.Close();
                            return status;
                        }
                    }
                    reader.Close();
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception($"[Payment.GetPaymentMethodByOrder] Failed for OrderID: {orderID}. " +
                            $" \nMessage: {ex.Message}");
            }
        }



        public static DataSet GetCompletedOrderDetails(int orderID)
        {
            try
            {
                string sql = $@"
                        SELECT 
                            p.paymentID,
                            p.orderID,
                            p.amount,
                            p.methodType,
                            p.paymentDate
                        FROM payments p                   
                        WHERE p.orderID = {orderID}";

                return Database.ExecuteMultiRowQuery(sql);
            }
            catch (Exception ex)
            {
                throw new Exception($"[Payment.GetCompletedOrderDetails] Could not retrieve data for OrderID: {orderID}. " +
                            $"\nMessage: {ex.Message}");
            }
        }

        public static void RefundPayment(int id)
        {
            try
            {
                string sql = $@"UPDATE payments
                            SET status = 'Refunded'
                            WHERE paymentID = {id}";

                Database.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                throw new Exception($"[Payment.RefundPayment] Could not update status to 'Refunded' for Payment ID: {id}. \nMessage: {ex.Message}");
            }
        }
        public static List<Order> LoadPaidOrders()
        {
            try
            {
                DataSet ds = GetPaidPayments();
                List<Order> orders = new List<Order>();

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    orders.Add(new Order(
                        Convert.ToInt32(row["OrderID"]),
                        table: new Table(
                            Convert.ToInt32(row["TableId"]),
                            Convert.ToInt32(row["TableNo"])
                            )
                    ));
                }

                return orders;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading paid orders:\n\n{ex.Message}",
                                "Database Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return new List<Order>();
            }
        }
    }
}
