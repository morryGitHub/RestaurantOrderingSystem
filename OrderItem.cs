using Oracle.ManagedDataAccess.Client;
using RestaurantOrderingSystem.OracleDatabase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantOrderingSystem
{
    internal class OrderItem
    {
        public int MenuItemID { get; set; }
        public int Quantity { get; set; }
        public int OrderID { get; set; }
        public string OrderStatus { get; set; }

        public OrderItem(int orderID, int menuItemID, int quantity)
        {
            OrderID = orderID;
            MenuItemID = menuItemID;
            Quantity = quantity;

        }

        public OrderItem(int orderID, int menuItemID)
        {
            OrderID = orderID;
            MenuItemID = menuItemID;

        }

        public OrderItem(int orderID)
        {
            OrderID = orderID;
        }

        public override string ToString()
        {
            return $"OrderID: {OrderID}, MenuItemID: {MenuItemID}, Quantity: {Quantity}";
        }

        public void AddOrderItems()
        {
            try
            {
                string checkSql = $"SELECT COUNT(*) FROM OrderItems WHERE orderid = {OrderID} AND menuitemid = {MenuItemID}";
                DataSet ds = Database.ExecuteMultiRowQuery(checkSql);

                string finalSql = $@"INSERT INTO OrderItems (orderid, menuitemid, quantity) 
                        VALUES ({OrderID}, {MenuItemID}, {Quantity})";


                Database.ExecuteNonQuery(finalSql);
            }
            catch (Exception ex)
            {
                throw new Exception($"[OrderItem.AddOrderItems] Failed to add ItemID {MenuItemID} to Order #{OrderID}. " +
            $" \nMessage: {ex.Message}");
            }
        }
        public static int GetLastOrderID()
        {
            try
            {
                string sql = $"SELECT MAX(OrderID) FROM Orders";

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
            catch (Exception ex)
            {
                throw new Exception($"[OrderItem.AddOrderItems] Failed to add ItemID to Order . " +
                            $"\nMessage: {ex.Message}");
            }
        }

        public DataSet GetMenuItemsFromOrder(string orderStatus)
        {
            try
            {
                string sql = $@"
                    SELECT 
                        o.OrderID AS OrderID,
                        t.TableNo AS TableNo,
                        o.TotalAmount AS TotalAmount,
                        oi.MenuItemID AS MenuItemID,
                        m.Name AS ItemName,
                        oi.Quantity AS Quantity,
                        m.UnitPrice AS UnitPrice
                    FROM Orders o
                    JOIN tablesinfo t 
                        ON o.TableId = t.TableId
                    JOIN OrderItems oi 
                        ON o.OrderID = oi.OrderID
                    JOIN MenuItems m 
                        ON oi.MenuItemID = m.MenuItemID
                    WHERE o.Status = '{orderStatus}' AND o.OrderID = {OrderID}";


                return Database.ExecuteMultiRowQuery(sql);
            }
            catch (Exception ex)
            {
                throw new Exception($"[OrderItem.GetMenuItemsFromOrder] Failed to load items for Order #{OrderID} ({orderStatus}). " +
                            $"\nCheck JOINs or Column Names. \nMessage: {ex.Message}");
            }
        }


        public void DeleteItemFromOrder()
        {
            try
            {
                string deleteItemSql = $@"DELETE FROM ORDERITEMS WHERE orderid = {OrderID} AND menuitemid = {MenuItemID}";
                Database.ExecuteNonQuery(deleteItemSql);
            }
            catch (Exception ex)
            {
                throw new Exception($"[OrderItem.DeleteAllItem] Failed to clear Order #{OrderID}. \nMessage: {ex.Message}");
            }
        }

        public void DeleteAllItemsFromOrder()
        {
            try
            {
                string deleteAllSql = $@"DELETE FROM ORDERITEMS WHERE orderid = {OrderID}";
                Database.ExecuteNonQuery(deleteAllSql);
            }
            catch (Exception ex)
            {
                throw new Exception($"[OrderItem.DeleteAllItems] Failed to clear Order #{OrderID}. \nMessage: {ex.Message}");
            }
        }
    }
}