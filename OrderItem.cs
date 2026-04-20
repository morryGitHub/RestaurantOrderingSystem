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
        public int ItemID;
        public int OrderID;
        public int MenuItemID;
        public int Quantity;

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

        public override string ToString()
        {
            return $"OrderID: {OrderID}, MenuItemID: {MenuItemID}, Quantity: {Quantity}";
        }

        public void AddOrderItems(bool isEditMode=false)
        {
            string checkSql = $"SELECT COUNT(*) FROM OrderItems WHERE orderid = {OrderID} AND menuitemid = {MenuItemID}";
            DataSet ds = Database.ExecuteMultiRowQuery(checkSql);

            int count = Convert.ToInt32(ds.Tables[0].Rows[0][0]);

            string finalSql;
            if (count > 0)
            {
                // 1. It exists, so Update
                if (isEditMode)
                {

                    finalSql = $@"UPDATE OrderItems SET quantity = {Quantity} 
                        WHERE orderid = {OrderID} AND menuitemid = {MenuItemID}";
                }
                else
                {
                    finalSql = $@"UPDATE OrderItems SET quantity = quantity + {Quantity} 
                        WHERE orderid = {OrderID} AND menuitemid = {MenuItemID}";
                }

            }
            else
            {
                // 2. It's new, so Insert
                finalSql = $@"INSERT INTO OrderItems (orderid, menuitemid, quantity) 
                        VALUES ({OrderID}, {MenuItemID}, {Quantity})";
            }

            Database.ExecuteNonQuery(finalSql);
        }

        public static int GetLastOrderID()
        {
            string sql = "SELECT MAX(orderID) FROM Orders";

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

        public static DataSet GetMenuItemsFromOrder(int orderID, string status)
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
                        ON o.TableID = t.TableID
                    JOIN OrderItems oi 
                        ON o.OrderID = oi.OrderID
                    JOIN MenuItems m 
                        ON oi.MenuItemID = m.MenuItemID
                    WHERE o.Status = '{status}' AND o.OrderID = {orderID}";


            return Database.ExecuteMultiRowQuery(sql);
        }


        public void DeleteItemFromOrder()
        {
            string deleteItemSql = $@"DELETE FROM ORDERITEMS WHERE orderid = {OrderID} AND menuitemid = {MenuItemID}";
            Database.ExecuteNonQuery(deleteItemSql);

        }
    }
}