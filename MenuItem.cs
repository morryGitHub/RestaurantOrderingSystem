using RestaurantOrderingSystem.OracleDatabase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderingSystem
{
    internal class MenuItem
    {
        public int ItemID { get; set; }     // DB ID
        public string Name { get; set; }
        public decimal Price { get; set; }

        public MenuItem(int itemID, string name, decimal price)
        {
            ItemID = itemID;
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name} - €{Price}";
        }

        public static DataSet LoadAllMenuItems()
        {
            string sql = @"
                SELECT MenuItemID, Name, UnitPrice
                FROM Menu_Item
                ORDER BY MenuItemID
            ";

            return Database.ExecuteMultiRowQuery(sql);
        }

        public static List<MenuItem> GetMenuItems()
        {
            DataSet ds = LoadAllMenuItems();
            List<MenuItem> menuItems = new List<MenuItem>();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                menuItems.Add(new MenuItem(
                    Convert.ToInt32(row["MENUITEMID"]),
                    row["NAME"].ToString(),
                    Convert.ToDecimal(row["UNITPRICE"]))
                );
            }

            return menuItems;
        }
    }
}
