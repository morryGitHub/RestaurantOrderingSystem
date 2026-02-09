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
        public int ReservationID;
        public int TableID;
        public string CustomerName;
        public string CustomerPhone;
        public string ReservationDateStart;
        public string ReservationDateEnd;
        public int NumOfGuest;


        public Reservation(int tableID, string customerName, string customerPhone, string reservationDateStart, string reservationDateEnd, int numOfGuest)
        {
            TableID = tableID;
            CustomerName = customerName;
            CustomerPhone = customerPhone;
            ReservationDateStart = reservationDateStart;
            ReservationDateEnd = reservationDateEnd;
            NumOfGuest = numOfGuest;
        }

        public static DataSet GetAvailableTablesForReservation(int numOfGuest, string start, string end)
        {
            string sql = $@"
                SELECT t.Table_ID, t.table_No, t.Capacity, t.Status
                FROM Restaurant_Tables t
                WHERE t.status = 'Available'
                  AND t.capacity >= {numOfGuest}
                  AND NOT EXISTS (
                      SELECT 1
                      FROM Reservations r
                      WHERE r.tableID = t.table_ID
                        AND TO_DATE('{start}', 'DD-MM-YYYY HH24:MI') < r.reservationDateTimeEnd
                        AND TO_DATE('{end}', 'DD-MM-YYYY HH24:MI') > r.reservationDateTimeStart
                    )";
            return Database.ExecuteMultiRowQuery(sql);
        }

        public void AddReservation()
        {
            string sql = $@"
                INSERT INTO Reservations(tableID, customerName, customerPhone, reservationDateTimeStart, reservationDateTimeEnd, numberOfGuests)
                Values({TableID}, '{CustomerName}', '{CustomerPhone}', TO_DATE('{ReservationDateStart}', 'DD-MM-YYYY HH24:MI'), TO_DATE('{ReservationDateEnd}', 'DD-MM-YYYY HH24:MI'), {NumOfGuest})
                ";

            Database.ExecuteNonQuery(sql);
        }
    }
}
