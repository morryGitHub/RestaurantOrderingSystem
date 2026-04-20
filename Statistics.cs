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
    internal class Statistics
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public decimal TotalRevenue { get; set; }
        public int OrdersCount { get; set; }

        public Statistics()
        {
        }

        public Statistics(int year)
        {
            Year = year;
        }

        public override string ToString()
        {
            return $"{Year}";
        }

        public static DataSet GetYears()
        {
            try
            {
                string sql = $@"
                SELECT 
                DISTINCT EXTRACT(YEAR FROM orderDate) AS year
                FROM orders
                ORDER BY year";
                return Database.ExecuteMultiRowQuery(sql);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error fetching years: {ex.Message}");

            }
        }

        public DataSet GetYearlyRevenue()
        {
            try
            {
                string sql = $@"
                    SELECT 
                        EXTRACT(MONTH FROM orderDate) AS month_num,
                        SUM(totalAmount) AS revenue
                    FROM orders
                    WHERE EXTRACT(YEAR FROM orderDate) = {Year}
                    GROUP BY EXTRACT(MONTH FROM orderDate)
                    ORDER BY EXTRACT(MONTH FROM orderDate)
                ";

                return Database.ExecuteMultiRowQuery(sql);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error fetching yearly revenue: {ex.Message}");
            }
        }

        public static DataSet GetTopMenuItems()
        {
            try
            {
                string sql = $@"
                   SELECT
                        m.name,
                        SUM(o.quantity) AS total,
                        SUM(o.quantity * m.unitprice) as total_cost
                    FROM orderitems o
                    JOIN menuitems m
                        ON o.menuitemid = m.menuitemid
                    GROUP BY
                        m.menuitemid,
                        m.name,
                        m.unitprice
                    ORDER BY total DESC
                    FETCH FIRST 10 ROWS ONLY
            ";
                return Database.ExecuteMultiRowQuery(sql);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error fetching top menu items: {ex.Message}");
            }
        }

        public static DataSet GetLeastMenuItems()
        {
            try
            {
                string sql = $@"
                   SELECT
                        m.name,
                        SUM(o.quantity) AS total,
                        SUM(o.quantity * m.unitprice) as total_cost
                    FROM orderitems o
                    JOIN menuitems m
                        ON o.menuitemid = m.menuitemid
                    GROUP BY
                        m.menuitemid,
                        m.name,
                        m.unitprice
                    ORDER BY total asc
                    FETCH FIRST 10 ROWS ONLY
            ";
                return Database.ExecuteMultiRowQuery(sql);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error fetching least menu items: {ex.Message}");
            }
        }

        public static DataSet GetNeverOrderedItems()
        {
            try
            {
                string sql = $@"
                   SELECT
                        m.name,
                        m.unitprice as unit_price
                    FROM orderitems o
                    right join menuitems m
                        ON o.menuitemid = m.menuitemid
                    GROUP BY
                        m.unitprice,
                        m.name
                    having COALESCE(SUM(o.quantity),0) = 0
            ";
                return Database.ExecuteMultiRowQuery(sql);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error fetching never ordered items: {ex.Message}");
            }
        }
        public static DataSet GetTotalRevenue()
        {
            try
            {

                string sql = $@"
                SELECT
                    SUM(totalamount) as total_revenue
                FROM orders";

                return Database.ExecuteMultiRowQuery(sql);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error fetching total revenue: {ex.Message}");
            }
        }


        public static DataSet GetTotalOrders()
        {
            try
            {
                string sql = $@"
                  SELECT
                       count(*) as total_orders
                  FROM orders";
                return Database.ExecuteMultiRowQuery(sql);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error fetching total orders: {ex.Message}");
            }
        }

        public static DataSet GetAverageAmountPerOrder()
        {
            try
            {
                string sql = $@"
                SELECT
                    Round(avg(totalamount), 2) as average_amount
                FROM orders";

                return Database.ExecuteMultiRowQuery(sql);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error fetching average amount per order: {ex.Message}");
            }
        }

        public static DataSet GetTotalBookings()
        {
            try
            {
                string sql = $@"
                SELECT
                    Count(*) as total_bookings
                FROM reservations
            ";
                return Database.ExecuteMultiRowQuery(sql);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error fetching total bookings: {ex.Message}");
            }
        }

        public static DataSet GetPaymentsByMethod()
        {
            try
            {
                string sql = $@"
                SELECT 
                    methodtype as payment_method, 
                    COUNT(*) AS total_amount
                FROM payments
                WHERE status = 'Paid'
                GROUP BY methodtype
            ";
                return Database.ExecuteMultiRowQuery(sql);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error fetching payments by method: {ex.Message}");
            }
        }

        public static DataSet GetTotalRefundedAmount()
        {
            try
            {
                string sql = $@"
                SELECT 
                    SUM(amount) AS refunded_total
                FROM payments
                WHERE status = 'Refunded'
            ";
                return Database.ExecuteMultiRowQuery(sql);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error fetching total refunded amount: {ex.Message}");
            }
        }




        public static List<Statistics> LoadYears()
        {
            try
            {
                DataSet ds = GetYears();
                List<Statistics> years = new List<Statistics>();

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    years.Add(new Statistics()
                    {
                        Year = Convert.ToInt32(row["year"])
                    }
                    );
                }

                return years;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading years: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return new List<Statistics>();
        }
    }
}