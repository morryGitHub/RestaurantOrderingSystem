using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantOrderingSystem.OracleDatabase
{
    public static class Database
    {
        private static readonly string _connectionString =
            ConfigurationManager.ConnectionStrings["OracleLocal"].ConnectionString;

        public static OracleConnection GetConnection()
        {
            try
            {
                OracleConnection conn = new OracleConnection(_connectionString);
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to establish a connection to the Oracle database:\n\n{ex.Message}",
                                "Connection Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                //Application.Exit();
                return null;
            }
        }


        public static DataSet ExecuteMultiRowQuery(string query)
        {
            //Open a connection to an Oracle database
            OracleConnection conn = GetConnection();


            //Formulate the DB request
            OracleCommand cmd = new OracleCommand(query, conn);

            //Use an OracleDataAdapter as a bridge between the DB and an in-memory
            //data structure (a DataSet in this case)
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Create the DataSet to hold results of the query
            DataSet ds = new DataSet();

            //Populate the DataSet with the results of the query
            //Note that Fill() will use the OracleCommand object to execute query
            da.Fill(ds);

            //Close DB connection
            conn.Close();

            return ds;
        }


        public static OracleDataReader ExecuteSingleRowQuery(string query)
        {
            //Open a connection to an Oracle database
            OracleConnection conn = GetConnection();

            //Formulate the DB request
            OracleCommand cmd = new OracleCommand(query, conn);

            //Execute the query and store the results in an OracleDataReader
            OracleDataReader dr = cmd.ExecuteReader();

            return dr;

        }

        public static void ExecuteNonQuery(string query)
        {
            //Open a connection to an Oracle database
            OracleConnection conn = GetConnection();

            //Formulate the DB request
            OracleCommand cmd = new OracleCommand(query, conn);

            //Execute the DB non-query
            cmd.ExecuteNonQuery();

            //Close the DB connection
            conn.Close();

        }

        public static bool IsDatabaseAvailable()
        {
            try
            {
                if (GetConnection() != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

