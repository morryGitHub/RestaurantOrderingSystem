using RestaurantOrderingSystem.OracleDatabase;
using System;
using System.Collections.Generic;
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
        public int TableNumber { get; set; }
        public string Status { get; set; }
        public int Capacity { get; set; }

        public Table()
        {
            Status = "AVAILABLE"; 
        }

        public Table(int tableNumber, int capacity)
        {
            TableNumber = tableNumber;
            Capacity = capacity;
            Status = "AVAILABLE"; 
        }

        public Table(int tableNumber, int capacity, string status)
        {
            TableNumber = tableNumber;
            Capacity = capacity;
            Status = status;
        }

        public override string ToString()
        {
            return "Table Number: " + TableNumber + "\tCapacity: " + Capacity + "\tStatus: " + Status;
        }

        public void AddTable()
        {
            Debug.WriteLine(this); //displaying the state of the Product object (for test purposes)

            //Define the SQL query to be executed
            string sqlQuery = "INSERT INTO RESTAURANT_TABLES (TABLE_NUMBER, SEATS, STATUS) " +
                  "VALUES (" + TableNumber + ", " + Capacity + ", '" + Status + "')";


            //Execute the SQL query
            Database.ExecuteNonQuery(sqlQuery);

        }




    }
}
