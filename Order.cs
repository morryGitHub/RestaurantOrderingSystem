using RestaurantOrderingSystem.OracleDatabase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantOrderingSystem
{
    internal class Order
    {
        public int Id { get; set; }
        public Table Table { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; } = "Active";

        public Order(Table table, DateTime orderDate, decimal totalAmount)
        {
            Table = table;
            OrderDate = orderDate;
            TotalAmount = totalAmount;
        }

        public Order(int orderID, Table table)
        {
            Id = orderID;
            Table = table;
        }


        public override string ToString()
        {
            return $"Order #{Id} — Table {Table.Number}";
        }

        public void AddOrder()
        {
            try
            {
                string sql = $@"
                INSERT INTO ORDERS(TableId, OrderDate, TotalAmount, Status)
                VALUES({Table.TableId}, TO_DATE('{OrderDate:yyyy-MM-dd HH:mm:ss}', 'YYYY-MM-DD HH24:MI:SS'), {TotalAmount}, '{Status}')";

                Database.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                throw new Exception($"[Order.AddOrder] Failed to create order for Table ID: {Table.TableId}. " +
                            $"\nAmount: {TotalAmount}, Status: {Status} " +
                            $"\nMessage: {ex.Message}");
            }
        }

        public void CancelOrder()
        {
            try
            {
                string sql = $@"
                UPDATE ORDERS
                SET STATUS = 'Cancelled'
                WHERE ORDERID = {Id}";

                Database.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                throw new Exception($"[Order.CancelOrder] Failed to cancel order #{Id}. \nMessage: {ex.Message}");
            }
        }


        public static DataSet GetActiveOrders()
        {
            try
            {
                string sql = $@"
                    SELECT
                         o.OrderID,
                         t.TableId,
                         t.TableNo   
                        
                    FROM Orders o
                    JOIN tablesinfo t ON o.TableId = t.TableId
                    WHERE o.Status = 'Active'";

                return Database.ExecuteMultiRowQuery(sql);
            }
            catch (Exception ex)
            {
                throw new Exception($"[Order.GetActiveOrders] Failed to retrieve active orders list. " +
            $"\nMessage: {ex.Message}");
            }
        }

        public static List<Order> LoadOrders()
        {
            try
            {
                DataSet ds = GetActiveOrders();
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
                MessageBox.Show($"Error loading orders: {ex.Message}",
                    "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Order>();

            }
        }
    }
}
