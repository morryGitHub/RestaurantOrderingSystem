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
        private int ReservationID;
        private int TableID;
        private string CustomerName;
        private string CustomerPhone;
        private string ReservationDateStart;
        private string ReservationDateEnd;
        private int NumOfGuest;
        private string Status;

        public Reservation(int reservationID)
        {
            ReservationID = reservationID;

        }
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

        public void DeleteReservation()
        {
            try
            {
                string sql = $@"
                    UPDATE RESERVATIONS
                    SET STATUS = 'CANCELLED'
                    WHERE RESERVATIONID = {ReservationID}";

                Database.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static DataSet GetAvailableTablesForReservation(int numOfGuest, string start, string end)
        {
            try
            {
                string sql = $@"
                SELECT t.TableID, t.tableNo, t.Capacity, t.Status
                FROM tablesinfo t
                WHERE t.status = 'Available'
                  AND t.capacity >= {numOfGuest}
                  AND NOT EXISTS (
                      SELECT 1
                      FROM Reservations r
                      WHERE r.tableID = t.tableID
                        AND TO_DATE('{start}', 'DD-MM-YYYY HH24:MI') < r.reservationDateTimeEnd
                        AND TO_DATE('{end}', 'DD-MM-YYYY HH24:MI') > r.reservationDateTimeStart
                    )
                ORDER BY t.Capacity";
                return Database.ExecuteMultiRowQuery(sql);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
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
            try
            {
                string sql = $@"
                SELECT t.TABLENO, r.TableID, r.CUSTOMERNAME,  r.CUSTOMERPHONE, r.RESERVATIONDATETIMESTART, r.NUMBEROFGUESTS, r.RESERVATIONID, r.STATUS
                FROM RESERVATIONS r
                JOIN tablesinfo t ON r.TABLEID = t.TableID
                WHERE r.STATUS = 'BOOKED'";

                if (id.HasValue)
                {
                    sql += $@" AND RESERVATIONID = {id}";
                }
                else
                {
                    if (!string.IsNullOrEmpty(phone))
                    {
                        sql += $@" AND CUSTOMERPHONE = '{phone}'";
                    }

                    if (!string.IsNullOrEmpty(name))
                    {
                        sql += $@" AND LOWER(CUSTOMERNAME) LIKE LOWER('%{name}%')";
                    }
                }



                return Database.ExecuteMultiRowQuery(sql);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateReservationDetails()
        {
            try
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
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AddReservation()
        {
            try
            {

                string sql = $@"
                INSERT INTO Reservations(tableID, customerName, customerPhone, reservationDateTimeStart, reservationDateTimeEnd, numberOfGuests, status)
                Values({TableID}, '{CustomerName}', '{CustomerPhone}', TO_DATE('{ReservationDateStart}', 'DD-MM-YYYY HH24:MI'), TO_DATE('{ReservationDateEnd}', 'DD-MM-YYYY HH24:MI'), {NumOfGuest}, 'BOOKED')
                ";

                Database.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}