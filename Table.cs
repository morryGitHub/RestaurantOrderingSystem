using Oracle.ManagedDataAccess.Client;
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
            Status = "Available";

        }

        public Table(int capacity)
        {
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
            return "Table Number: " + TableNumber + "\tCapacity: " + Capacity + "\tStatus: " + Status;
        }

        public void AddTable()
        {
            Debug.WriteLine(this); //displaying the state of the Product object (for test purposes)

            //Define the SQL query to be executed
            string sqlQuery = "INSERT INTO RESTAURANT_TABLES (CAPACITY, STATUS) " +
                  "VALUES (" + Capacity + ", '" + Status + "')";


            //Execute the SQL query
            Database.ExecuteNonQuery(sqlQuery);

        }
        public static int GetNextTableID()
        {

            //Define the SQL query to be executed - only one value returned here
            string sqlQuery = "SELECT MAX(TABLE_ID) FROM RESTAURANT_TABLES";

            //Execute the SQL query
            OracleDataReader dr = Database.ExecuteSingleRowQuery(sqlQuery);

            //Does data reader contain a value or is it null?
            int nextId;
            dr.Read();

            if (dr.IsDBNull(0)) //the data reader is empty so no rows have yet been added to the table
                nextId = 1;
            else
                nextId = dr.GetInt32(0) + 1;

            //close the OracleDataReader and the DB connection
            dr.Close();

            return nextId;
        }

        /* 🥈 OPTION 2: Truncate + reset identity (Oracle 18c+)

If your Oracle version supports it:

TRUNCATE TABLE RESTAURANT_TABLES;

ALTER TABLE RESTAURANT_TABLES
MODIFY table_id GENERATED ALWAYS AS IDENTITY (START WITH 1);


⚠️ Works only on newer Oracle versions]



        CREATE TABLE RESTAURANT_TABLES (
    table_id INT GENERATED ALWAYS AS IDENTITY,
    capacity INT NOT NULL CHECK (capacity > 0),
    status   VARCHAR2(20) NOT NULL
        CHECK (status IN ('Available', 'Reserved', 'Occupied'))
);

         */




    }
}
