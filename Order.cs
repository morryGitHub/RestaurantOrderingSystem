using RestaurantOrderingSystem.OracleDatabase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderingSystem
{
    internal class Order
    {
        public int ID;
        public Table Table;
        public DateTime OrderDate;
        public decimal TotalAmount;
        public string Status;

        public Order(Table table, DateTime orderDate, decimal totalAmount)
        {
            Table = table;
            OrderDate = orderDate;
            TotalAmount = totalAmount;
            Status = "Active";
        }

        public Order(int orderID, Table table)
        {
            ID = orderID;
            Table = table;
        }

        public override string ToString()
        {
            return $"Order #{ID} — Table {Table.TableNumber}";
        }

        public void AddOrder()
        {
            string sql = $@"
                INSERT INTO ORDERS(TableID, OrderDate, TotalAmount, Status)
                VALUES({Table.TableId}, TO_DATE('{OrderDate:yyyy-MM-dd HH:mm:ss}', 'YYYY-MM-DD HH24:MI:SS'), {TotalAmount}, '{Status}')
            ";

            Database.ExecuteNonQuery(sql);
        }

        public void ChangeTableStatus(int tableID)
        {
            string sql = $@"
                    UPDATE ORDERS
                    SET Status = 'Unavailable'";

            Database.ExecuteSingleRowQuery(sql);
        }

        public void CancelOrder(int orderID)
        {
            string sql = $@"
                UPDATE ORDERS
                SET STATUS = 'Cancelled'
                WHERE ORDERID = {orderID}";

            Database.ExecuteNonQuery(sql);
        }


        public static DataSet GetActiveOrders()
        {
            string sql = $@"
                    SELECT
                         o.OrderID,
                         t.TableID,
                         t.TableNo   
                        
                    FROM Orders o
                    JOIN tablesinfo t ON o.TableID = t.TableID
                    WHERE o.Status = 'Active'";

            return Database.ExecuteMultiRowQuery(sql);
        }

        public static List<Order> LoadOrders()
        {
            DataSet ds = GetActiveOrders();
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
