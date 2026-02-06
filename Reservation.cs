using RestaurantOrderingSystem.OracleDatabase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderingSystem
{
    internal class Reservation
    {
        public int reservationID;
        public int tableID;
        public string customerName;
        public string customerPhone;
        public DateTime reservationDate;
        public int numOfGuest;

        public Reservation() { }

        public static DataSet GetAvailableTablesForReservation(int numOfGuest)
        {
            string sql = $@"
                SELECT Table_ID, Table_No, Capacity, Status
                FROM Restaurant_Tables
                WHERE Capacity >= {numOfGuest} 
                    AND Status = 'Available'
                ";
            return Database.ExecuteMultiRowQuery(sql);
        }
    }
}
