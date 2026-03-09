using RestaurantOrderingSystem.OracleDatabase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderingSystem
{
    internal class Statistics
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public decimal TotalRevenue { get; set; }
        public int OrdersCount { get; set; }

        public Statistics()
        {

        }

        public override string ToString()
        {
            return $"{Year}";
        }

        public static DataSet GetYears()
        {

            string sql = $@"
            SELECT 
                DISTINCT EXTRACT(YEAR FROM orderDate) AS year
            FROM orders
            ORDER BY year";
            return Database.ExecuteMultiRowQuery(sql);
        }

        public DataSet GetYearlyRevenue()
        {
            string sql = $@"
                SELECT 
                    EXTRACT(YEAR FROM orderDate) AS year,
                    EXTRACT(MONTH FROM orderDate) AS month,
                    SUM(totalAmount) AS revenue
                FROM orders
                WHERE  EXTRACT(YEAR FROM orderDate) = {Year}
                GROUP BY 
                    EXTRACT(YEAR FROM orderDate),
                    EXTRACT(MONTH FROM orderDate)
                ORDER BY year, month;     
            ";

            return Database.ExecuteMultiRowQuery(sql);
        }
        public static List<Statistics> LoadYears()
        {
            DataSet ds = GetYears();
            List<Statistics> years = new List<Statistics>();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                years.Add(new Statistics
                {
                    Year = Convert.ToInt32(row["year"])
                });
            }

            return years;
        }
    }
}
