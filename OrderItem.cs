using Oracle.ManagedDataAccess.Client;
using RestaurantOrderingSystem.OracleDatabase;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderingSystem
{
    internal class OrderItem
    {
        public int ItemID;
        public int OrderID;
        public int MenuItemID;
        public int Quantity;
        public decimal UnitPrice;

        public OrderItem(int orderID, int menuItemID, int quantity, decimal unitPrice)
        {
            OrderID = orderID;
            MenuItemID = menuItemID;
            Quantity = quantity;
            UnitPrice = unitPrice;

        }

        public override string ToString()
        {
            return $"OrderID: {OrderID}, MenuItemID: {MenuItemID}, Quantity: {Quantity}, UnitPrice: {UnitPrice}";
        }

        public void AddOrderItems()
        {
            string sqlOrder = $@"
                INSERT INTO OrderItems(orderID, menuItemID, quantity, unitPrice)
                VALUES({OrderID}, {MenuItemID}, {Quantity}, {UnitPrice})";


            // ExecuteScalar вернёт только что созданный itemID

            Database.ExecuteNonQuery(sqlOrder);
        }

        public static int GetLastOrderID()
        {
            string sql = "SELECT MAX(orderID) FROM OrderItems";

            OracleDataReader reader = Database.ExecuteSingleRowQuery(sql);

            if (reader != null)
            {
                if (reader.Read()) 
                {
                    if (!reader.IsDBNull(0))
                    {
                        int newOrderID = reader.GetInt32(0);
                        reader.Close();
                        return newOrderID;
                    }
                }
                reader.Close();
            }

            return 1; 
        }

    }

}
