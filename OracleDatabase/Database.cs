using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderingSystem.OracleDatabase
{
    public static class Database
    {
        private static readonly string _connectionString =
            ConfigurationManager.ConnectionStrings["OracleDb"].ConnectionString;

        public static OracleConnection GetConnection()
        {
            OracleConnection conn = new OracleConnection(_connectionString);
            conn.Open();
            return conn;
        }
    }
}
