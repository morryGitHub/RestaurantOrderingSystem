using Oracle.ManagedDataAccess.Client;
using RestaurantOrderingSystem.OracleDatabase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RestaurantOrderingSystem
{
    class Table
    {

        public int TableId { get; set; }     // DB TableId
        public int Number { get; set; }
        public int Capacity { get; set; }
        public string Status { get; set; } = "Available";
        public string Location { get; set; } = "Main Hall";



        public Table(int tableId, int tableNumber, int capacity, string status, string location)
        {
            TableId = tableId;
            Number = tableNumber;
            Capacity = capacity;
            Status = status;
            Location = location;
        }

        public Table(int tableNumber, int capacity, string status, string location)
        {
            Number = tableNumber;
            Capacity = capacity;
            Status = status;
            Location = location;
        }

        public Table(int tableID, int tableNumber, int capacity)
        {
            TableId = tableID;
            Number = tableNumber;
            Capacity = capacity;
        }

        public Table(int tableNumber, int capacity, string location)
        {
            Number = tableNumber;
            Capacity = capacity;
            Location = location;
        }


        public Table(int tableNumber, int capacity)
        {
            Number = tableNumber;
            Capacity = capacity;
        }



        public Table() : this(0, 0, 0, "Available", "Main Hall") { }



        public override string ToString()
        {
            return $"Table #{Number} ({Capacity} seats)";
        }
        public void AddTable()
        {
            try
            {
                string sql = $@"
                                 INSERT INTO tablesinfo (TABLENO, CAPACITY, STATUS, LOCATION)
                                 VALUES ({Number}, {Capacity}, '{Status}', '{Location}')
                             ";

                Database.ExecuteNonQuery(sql);
            }
            catch (OracleException ex)
            {
                throw new Exception($"[Table.AddTable] Database error! Code: {ex.Number}. \nMessage: {ex.Message}");
            }
        }

        public DataSet GetTableData()
        {
            try
            {
                string sql = $@"
                    SELECT TABLEID, TABLENO, CAPACITY, Location
                    FROM tablesinfo
                    WHERE TABLEID = {TableId}
                    ";

                return Database.ExecuteMultiRowQuery(sql);

            }
            catch (OracleException ex)
            {
                throw new Exception($"[Table.GetTableData] Failed to fetch table {TableId}.\nMessage: {ex.Message}");
            }
        }

        public Table GetTable()
        {
            try
            {
                DataSet ds = GetTableData();

                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    int id = Convert.ToInt32(ds.Tables[0].Rows[0]["TABLEID"]);
                    int no = Convert.ToInt32(ds.Tables[0].Rows[0]["TABLENO"]);
                    int capacity = Convert.ToInt32(ds.Tables[0].Rows[0]["CAPACITY"]);

                    return new Table(id, no, capacity);
                }

                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static DataSet LoadAllTables()
        {
            try
            {
                //Define the SQL query to be executed
                string sql = @"
                SELECT TABLEID, TABLENO, CAPACITY, STATUS, LOCATION
                FROM tablesinfo
                ORDER BY TABLENO";

                //Execute the SQL query
                return Database.ExecuteMultiRowQuery(sql);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static DataSet LoadAvailableTables()
        {
            try
            {
                //Define the SQL query to be executed
                string sql = @"
                    SELECT t.TABLEID, t.TABLENO, t.CAPACITY, t.STATUS, t.LOCATION
                    FROM tablesinfo t
                    WHERE t.STATUS = 'Available'
                      AND NOT EXISTS (
                          SELECT 1 
                          FROM ORDERS o 
                          WHERE o.TableId = t.TableId 
                            AND o.STATUS = 'Active'
                      )
                    ORDER BY t.TABLENO";

                //Execute the SQL query
                return Database.ExecuteMultiRowQuery(sql);
            }
            catch (Exception ex)
            {
                throw new Exception($"[Table.LoadAvailableTables] Failed to load available tables list. " +
                                            $"\nMessage: {ex.Message}");
            }
        }

        public void UpdateTable()
        {
            try
            {
                string sqlQuery = $@"UPDATE tablesinfo SET
                     CAPACITY = {Capacity},
                     STATUS = '{Status}',
                     LOCATION = '{Location}'
                     WHERE TABLENO = {Number}";

                //Execute the SQL query
                Database.ExecuteNonQuery(sqlQuery);
            }
            catch (OracleException ex)
            {
                throw new Exception($"[Table.UpdateTable] Update failed for table No: {Number}. \nMessage: {ex.Message}");
            }
        }

        public void DeleteTable()
        {
            try
            {
                //Define the SQL query to be executed
                string sqlQuery = $@"
                    UPDATE tablesinfo
                    SET STATUS = 'Unavailable' 
                    WHERE TABLENO = {Number}";


                //Execute the SQL query
                Database.ExecuteNonQuery(sqlQuery);
            }
            catch (OracleException ex)
            {
                throw new Exception($"[Table.DeleteTable] Could not set status to 'Unavailable' for table {Number}. \nMessage: {ex.Message}");
            }
        }

        public static int GetLastTableID()
        {
            try
            {
                string sql = "SELECT MAX(TABLENO) FROM tablesinfo";
                OracleDataReader reader = Database.ExecuteSingleRowQuery(sql);

                if (reader != null)
                {
                    if (reader.Read())
                    {

                        if (!reader.IsDBNull(0))
                        {
                            int newTableNo = Convert.ToInt32(reader.GetValue(0)) + 1;
                            reader.Close();
                            return newTableNo;
                        }
                    }
                    reader.Close();
                }

                return 1;
            }
            catch (OracleException ex)
            {
                throw new Exception($"[Table.GetLastTableID] Failed to get MAX(TABLENO). \nMessage: {ex.Message}");
            }
        }

        public static List<Table> GetTables()
        {
            try
            {
                DataSet ds = LoadAllTables();
                List<Table> tables = new List<Table>();

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    tables.Add(new Table(
                        Convert.ToInt32(row["TABLEID"]),
                        Convert.ToInt32(row["TABLENO"]),
                        Convert.ToInt32(row["CAPACITY"]),
                        row["STATUS"].ToString(),
                        row["LOCATION"].ToString()
                    ));
                }

                return tables;
            }
            catch (Exception)
            {
                throw;

            }

        }

        public static List<Table> GetAvailableTables()
        {
            try
            {
                DataSet ds = LoadAvailableTables();
                List<Table> tables = new List<Table>();

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    tables.Add(item: new Table(
                        Convert.ToInt32(row["TABLEID"]),
                        Convert.ToInt32(row["TABLENO"]),
                        Convert.ToInt32(row["CAPACITY"]),
                        row["STATUS"].ToString(),
                        row["Location"].ToString()
                    ));
                }

                return tables;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
