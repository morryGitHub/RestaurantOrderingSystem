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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RestaurantOrderingSystem
{
    class Table
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
        public Table(int tableId = 0, int tableNumber = 0, int capacity = 0, string status = "Available")
        {
            TableId = tableId;
            TableNumber = tableNumber;
            Capacity = capacity;
            Status = status;
        }

        public Table(int tableID, int tableNumber, int capacity)
        {
            TableId = tableID;
            TableNumber = tableNumber;
            Capacity = capacity;
        }

        public Table(int tableNumber, int capacity, string status)
        {
            TableNumber = tableNumber;
            Capacity = capacity;
            Status = status;
        }

        public Table(int tableNumber, int capacity)
        {
            TableNumber = tableNumber;
            Capacity = capacity;
            Status = Status;
        }


        public override string ToString()
        {
            return $"Table #{TableNumber} ({Capacity} seats)";
        }
        public void AddTable()
        {
            try
            {
                string sql = $@"
                                 INSERT INTO tablesinfo (TABLENO, CAPACITY, STATUS)
                                 VALUES ({TableNumber}, {Capacity}, '{Status}')
                             ";

                Database.ExecuteNonQuery(sql);
            }
            catch (OracleException ex)
            {
                throw new Exception("Database error: " + ex.Message);
            }
        }

        public static Table GetTable(int tableID)
        {
            string sql = $@"
                    SELECT TABLEID, TABLENO, CAPACITY
                    FROM tablesinfo
                    WHERE TABLEID = {tableID}
                    ";

            using (IDataReader reader = Database.ExecuteSingleRowQuery(sql))
            {
                if (reader.Read())
                {
                    int id = Convert.ToInt32(reader["TABLEID"]);
                    int no = Convert.ToInt32(reader["TABLENO"]);
                    int capacity = Convert.ToInt32(reader["CAPACITY"]);
                    return new Table(id, no, capacity);
                }

            }
            return null;



        }

        public static DataSet LoadAllTables()
        {
            //Define the SQL query to be executed
            string sql = @"
                SELECT TABLEID, TABLENO, CAPACITY, STATUS
                FROM tablesinfo
                ORDER BY TABLENO
            ";

            //Execute the SQL query
            return Database.ExecuteMultiRowQuery(sql);
        }

        public static DataSet LoadAvailableTables()
        {
            //Define the SQL query to be executed
            string sql = @"
                SELECT t.TABLEID, t.TABLENO, t.CAPACITY, t.STATUS, o.Status
                FROM tablesinfo t
                LEFT JOIN ORDERS o 
                    ON t.TableID = o.TableID
                WHERE t.STATUS = 'Available' 
                    AND (o.Status IS NULL or o.STATUS != 'Active')
                ORDER BY TABLENO
            ";

            //Execute the SQL query
            return Database.ExecuteMultiRowQuery(sql);
        }

        public void UpdateTable()
        {
            string sqlQuery = "UPDATE tablesinfo SET " +
               "CAPACITY = '" + Capacity + "'," +
               "STATUS = '" + Status + "' " +
               "WHERE TABLENO = " + TableNumber;

            //Execute the SQL query
            Database.ExecuteNonQuery(sqlQuery);
        }

        public static void DeleteTable(int tableNo)
        {
            //Define the SQL query to be executed
            string sqlQuery = $@"
                    UPDATE tablesinfo
                    SET STATUS = 'Unavailable' 
                    WHERE TABLENO = {tableNo}";


            //Execute the SQL query
            Database.ExecuteNonQuery(sqlQuery);

        }

        public static int GetLastTableID()
        {
            string sql = "SELECT MAX(TABLENO) FROM tablesinfo";
            OracleDataReader reader = Database.ExecuteSingleRowQuery(sql);

            if (reader != null)
            {
                if (reader.Read())
                {
                    Debug.WriteLine("reader.Read()");

                    if (!reader.IsDBNull(0))
                    {
                        Debug.WriteLine("newTableNo");
                        int newTableNo = Convert.ToInt32(reader.GetValue(0)) + 1;
                        Debug.WriteLine(newTableNo);
                        reader.Close();
                        return newTableNo;
                    }
                }
                reader.Close();
            }

            return 1;
        }

        public static List<Table> GetTables()
        {
            DataSet ds = LoadAllTables();
            List<Table> tables = new List<Table>();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                tables.Add(new Table(
                    Convert.ToInt32(row["TABLENO"]),
                    Convert.ToInt32(row["CAPACITY"]),
                    row["STATUS"].ToString()
                ));
            }

            return tables;
        }

        public static List<Table> GetAvailableTables()
        {
            DataSet ds = LoadAvailableTables();
            List<Table> tables = new List<Table>();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                tables.Add(item: new Table(
                    Convert.ToInt32(row["TABLEID"]),
                    Convert.ToInt32(row["TABLENO"]),
                    Convert.ToInt32(row["CAPACITY"]),
                    row["STATUS"].ToString()
                ));
            }

            return tables;
        }



    }
}
