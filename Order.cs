using RestaurantOrderingSystem.OracleDatabase;
using System;
using System.Collections.Generic;
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

        public override string ToString()
        {
            return "";
        }

        public void AddOrder()
        {
            string sql = $@"
                INSERT INTO ORDERS(TableID, OrderDate, TotalAmount, Status)
                VALUES({TableID}, TO_DATE('{OrderDate:yyyy-MM-dd HH:mm:ss}', 'YYYY-MM-DD HH24:MI:SS'), {TotalAmount}, '{Status}')
            ";

            Database.ExecuteNonQuery(sql);
        }
    }
}
