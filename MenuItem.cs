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
    internal class MenuItem
    {
        public int ID { get; set; } 
        public string Name { get; set; }
        public decimal Price { get; set; }

        public MenuItem(int itemID, string name, decimal price)
        {
            ID = itemID;
            Name = name;
            Price = price;
        }


        public MenuItem(int itemID, string name)
        {
            ID = itemID;
            Name = name;
        }



        public override string ToString()
        {
            return $"{Name} - €{Price}";
        }



        public static DataSet LoadAllMenuItems()
        {
            try
            {
                string sql = @"
                SELECT MenuItemID, Name, UnitPrice
                FROM MenuItems
                ORDER BY Name
            ";

                return Database.ExecuteMultiRowQuery(sql);
            }
            catch (Exception ex)
            {
                throw new Exception($"[MenuItem.LoadAllMenuItems] Failed to load menu. " +
             $" \nMessage: {ex.Message}");
            }
        }

        public static List<MenuItem> GetMenuItems()
        {
            try
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
            catch (Exception)
            {
                throw;
            }
        }
    }
}
