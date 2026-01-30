using Oracle.ManagedDataAccess.Client;
using RestaurantOrderingSystem.OracleDatabase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RestaurantOrderingSystem
{
    public class Table
    {
        //Properties of the class
        public int TableId { get; set; }     // DB ID
        public int TableNumber { get; set; }
        public int Capacity { get; set; }
        public string Status { get; set; } = "Available";


        public Table()
        {
            Status = "Available";

        }

        public Table(int tableNumber, int capacity)
        {
            TableNumber = tableNumber;
            Capacity = capacity;
            Status = "Available";
        }

        public Table(int tableNumber, int capacity, string status)
        {
            TableNumber = tableNumber; // DB-generated ID
            Capacity = capacity;
            Status = status;
        }


        public override string ToString()
        {
            return $"Table #{TableNumber} ({Capacity} seats)";
        }
        public void AddTable()
        {
            //Define the SQL query to be executed

            string sql = $@"
                INSERT INTO RESTAURANT_TABLES (TABLE_NO, CAPACITY, STATUS)
                VALUES ({TableNumber}, {Capacity}, '{Status}')";

            //Execute the SQL query
            Database.ExecuteNonQuery(sql);
        }

        public static DataSet GetAllTables()
        {
            //Define the SQL query to be executed
            string sql = @"
                SELECT TABLE_ID, TABLE_NO, CAPACITY, STATUS
                FROM RESTAURANT_TABLES
                ORDER BY TABLE_NO
            ";

            //Execute the SQL query
            return Database.ExecuteMultiRowQuery(sql);
        }

        public void UpdateTable() {
            string sqlQuery = "UPDATE RESTAURANT_TABLES SET " +
               "CAPACITY = '" + Capacity + "'," +
               "STATUS = '" + Status + "' " +
               "WHERE TABLE_NO = " + TableNumber;

            //Execute the SQL query
            Database.ExecuteNonQuery(sqlQuery);
        }

        public static void DeleteTable(int tableNo)
        {
            //Define the SQL query to be executed
            string sqlQuery = $"DELETE FROM RESTAURANT_TABLES WHERE TABLE_NO = {tableNo}";


            //Execute the SQL query
            Database.ExecuteNonQuery(sqlQuery);

        }
        public static int? GetNextFreeTableNumber()
        {
            string sql = @"
                SELECT MIN(n)
                FROM (
                    SELECT LEVEL n FROM dual CONNECT BY LEVEL <= 20
                )
                WHERE n NOT IN (
                    SELECT TABLE_NO FROM RESTAURANT_TABLES
                )
            ";

            OracleDataReader dr = Database.ExecuteSingleRowQuery(sql);
            dr.Read();

            if (dr.IsDBNull(0))
                return null;

            return dr.GetInt32(0);
        }
    }
}
