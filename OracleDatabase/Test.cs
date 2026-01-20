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
                    Console.WriteLine("✅ Подключение к Oracle успешно!");
                } // conn.Close() вызывается автоматически
            }
            catch (OracleException ex)
            {
                Console.WriteLine("❌ Ошибка подключения к Oracle");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
