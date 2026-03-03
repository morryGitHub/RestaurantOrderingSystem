using Oracle.ManagedDataAccess.Client;
using RestaurantOrderingSystem.OracleDatabase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderingSystem
{
    internal class Payment
    {
        private Order Order;
        //private Table Table;
        private int PaymentID;
        private decimal Amount;
        private string MethodType;
        private string PaymentDate;
        private string Status;


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
            return $"Table #{Order.Table.TableId} — Order {Order.ID}";
        }

        public void MakePayment()
        {
            string sql = $@"
                    BEGIN 

                        INSERT INTO PAYMENTS(orderID, amount, methodType, paymentDate)
                        VALUES({Order.ID},{Amount},'{MethodType}',TO_DATE('{PaymentDate}', 'DD-MM-YYYY HH24:MI'));

                        UPDATE ORDERS
                        SET STATUS = 'Completed'
                        WHERE OrderID = {Order.ID};
                    
                    END;
                ";

            Database.ExecuteNonQuery(sql);
        }

        public static DataSet GetPaidPayments()
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

        public static string GetPaymentMethodByOrder(int orderID)
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



        public static DataSet GetCompletedOrderDetails(int orderID)
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

        public static void RefundPayment(int id)
        {
            string sql = $@"UPDATE payments
                            SET status = 'Refunded'
                            WHERE paymentID = {id}";

            Database.ExecuteNonQuery(sql);
        }

        public static List<Order> LoadPaidOrders()
        {
            DataSet ds = GetPaidPayments();
            List<Order> orders = new List<Order>();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                orders.Add(new Order(
                    Convert.ToInt32(row["OrderID"]),
                    table: new Table(
                        Convert.ToInt32(row["TableID"]),
                        Convert.ToInt32(row["TableNo"])
                        )
                ));
            }

            return orders;
        }

    }
}
