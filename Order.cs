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
        public int OrderID;
        public int TableID;
        public DateTime OrderDate;
        public decimal TotalAmount;
        public string Status;

        public Order(int tableID, DateTime orderDate, decimal totalAmount)
        {
            TableID = tableID;
            OrderDate = orderDate;
            TotalAmount = totalAmount;
            Status = "Active";
        }

        public Order(int orderID, int tableID)
        {
            OrderID = orderID;
            TableID = tableID;
        }

        public override string ToString()
        {
            return $"Order #{OrderID} — Table {TableID}";
        }

        public void AddOrder()
        {
            string sql = $@"
                INSERT INTO ORDERS(TableID, OrderDate, TotalAmount, Status)
                VALUES({TableID}, TO_DATE('{OrderDate:yyyy-MM-dd HH:mm:ss}', 'YYYY-MM-DD HH24:MI:SS'), {TotalAmount}, '{Status}')
            ";

            Database.ExecuteNonQuery(sql);
        }

  
        public static DataSet GetActiveOrders()
        {
            string sql = $@"
                    SELECT
                         o.OrderID     AS OrderID,
                         t.Table_No    AS TableNo
                    FROM Orders o
                    JOIN Restaurant_Tables t ON o.TableID = t.Table_ID
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
                    Convert.ToInt32(row["TableNo"])
                ));
            }

            return orders;
        }

    }
}
