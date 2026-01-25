using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderingSystem.OracleDatabase
{
    internal class Test
    {
        static void Main()
        {
        
            TestConnection();
        }

        static void TestConnection()
        {
            try
            {
                using (OracleConnection conn =
                       new OracleConnection(Database.connectionString))
                {
                    conn.Open();
                    Console.WriteLine("Connected to Oracle succesfully!");
                } 
            }
            catch (OracleException ex)
            {
                Console.WriteLine("Oracle connection error");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
