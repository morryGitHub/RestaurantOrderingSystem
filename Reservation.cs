using RestaurantOrderingSystem.OracleDatabase;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        public string Status;


        public Reservation(int reservationID, int tableID, string customerName, string customerPhone, string reservationDateStart, string reservationDateEnd, int numOfGuest, string status)
        {
            ReservationID = reservationID;
            TableID = tableID;
            CustomerName = customerName;
            CustomerPhone = customerPhone;
            ReservationDateStart = reservationDateStart;
            ReservationDateEnd = reservationDateEnd;
            NumOfGuest = numOfGuest;
            Status = status;
        }

        public Reservation(int tableID, string customerName, string customerPhone, string reservationDateStart, string reservationDateEnd, int numOfGuest)
        {
            TableID = tableID;
            CustomerName = customerName;
            CustomerPhone = customerPhone;
            ReservationDateStart = reservationDateStart;
            ReservationDateEnd = reservationDateEnd;
            NumOfGuest = numOfGuest;
        }
        public Reservation(int tableID, string customerName, string customerPhone, string reservationDateStart, int numOfGuest)
        {
            TableID = tableID;
            CustomerName = customerName;
            CustomerPhone = customerPhone;
            ReservationDateStart = reservationDateStart;
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
                    )
                ORDER BY t.Capacity";
            return Database.ExecuteMultiRowQuery(sql);
        }

        public static DataSet GetReservationDetails(int id)
        {

            return GetReservationDetailsInternal(id, null, null);
        }

        public static DataSet GetReservationDetails(string phone, string name)
        {

            return GetReservationDetailsInternal(null, phone, name);
        }

        private static DataSet GetReservationDetailsInternal(int? id, string phone, string name)
        {

            string sql = $@"
                SELECT t.TABLE_NO AS TableNo, r.TableID, r.CUSTOMERNAME,  r.CUSTOMERPHONE, r.RESERVATIONDATETIMESTART, r.NUMBEROFGUESTS, r.RESERVATIONID, r.STATUS
                FROM RESERVATIONS r
                JOIN RESTAURANT_TABLES t ON r.TABLEID = t.Table_ID
                WHERE 1=0";

            if (id.HasValue)
            {
                sql += $@" OR RESERVATIONID = {id}";
            }
            else
            {
                if (!string.IsNullOrEmpty(phone))
                {
                    sql += $@" OR CUSTOMERPHONE = '{phone}'";
                }

                if (!string.IsNullOrEmpty(name))
                {
                    sql += $@" OR CUSTOMERNAME LIKE '%{name}%'";
                }
            }



            return Database.ExecuteMultiRowQuery(sql);

        }

        public void UpdateReservationDetails()
        {
            string sql = $@"
                UPDATE RESERVATIONS
                SET CUSTOMERNAME = '{CustomerName}',
                    CUSTOMERPHONE = '{CustomerPhone}',
                    RESERVATIONDATETIMESTART = TO_DATE('{ReservationDateStart}', 'YYYY-MM-DD HH24:MI:SS'),
                    RESERVATIONDATETIMEEND = TO_DATE('{ReservationDateEnd}', 'YYYY-MM-DD HH24:MI:SS'),
                    NUMBEROFGUESTS = {NumOfGuest},
                    TABLEID = {TableID},
                    STATUS = '{Status}'
                WHERE RESERVATIONID = {ReservationID}";


            Database.ExecuteNonQuery(sql);
        }

        public void AddReservation()
        {
            string sql = $@"
                INSERT INTO Reservations(tableID, customerName, customerPhone, reservationDateTimeStart, reservationDateTimeEnd, numberOfGuests, status)
                Values({TableID}, '{CustomerName}', '{CustomerPhone}', TO_DATE('{ReservationDateStart}', 'DD-MM-YYYY HH24:MI'), TO_DATE('{ReservationDateEnd}', 'DD-MM-YYYY HH24:MI'), {NumOfGuest}, 'BOOKED')
                ";

            Database.ExecuteNonQuery(sql);
        }
    }
}
