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
        public int ReservationId { get; set; }
        public int TableId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public string ReservationDateStart { get; set; }
        public string ReservationDateEnd { get; set; }
        public int GuestCount { get; set; }
        public string Status { get; set; }

        public Reservation(int id, int tableId, string customerName, string customerPhone, string reservationDateStart, string reservationDateEnd, int guestCount, string status)
        {
            ReservationId = id;
            TableId = tableId;
            CustomerName = customerName;
            CustomerPhone = customerPhone;
            ReservationDateStart = reservationDateStart;
            ReservationDateEnd = reservationDateEnd;
            GuestCount = guestCount;
            Status = status;
        }

        public Reservation(int tableId, string customerName, string customerPhone, string reservationDateStart, string reservationDateEnd, int guestCount)
        {
            TableId = tableId;
            CustomerName = customerName;
            CustomerPhone = customerPhone;
            ReservationDateStart = reservationDateStart;
            ReservationDateEnd = reservationDateEnd;
            GuestCount = guestCount;
        }
        public Reservation(int tableId, string customerName, string customerPhone, string reservationDateStart, int guestCount)
        {
            TableId = tableId;
            CustomerName = customerName;
            CustomerPhone = customerPhone;
            ReservationDateStart = reservationDateStart;
            GuestCount = guestCount;
        }

        public Reservation(string reservationDateStart, string reservationDateEnd, int guestCount)
        {
            ReservationDateStart = reservationDateStart;
            ReservationDateEnd = reservationDateEnd;
            GuestCount = guestCount;
        }

        public Reservation(int id)
        {
            ReservationId = id;
        }

        public void DeleteReservation()
        {
            try
            {
                string sql = $@"
                    UPDATE RESERVATIONS
                    SET STATUS = 'CANCELLED'
                    WHERE RESERVATIONID = {ReservationId}";

                Database.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                throw new Exception($"[Reservation.DeleteReservation] Failed to cancel reservation #{ReservationId}. \nMessage: {ex.Message}");
            }
        }

        public DataSet GetAvailableTablesForReservation()
        {
            try
            {
                string sql = $@"
                SELECT t.tableId, t.tableNo, t.Capacity, t.Status, t.Location
                FROM tablesinfo t
                WHERE t.status = 'Available'
                  AND t.capacity >= {GuestCount}
                  AND NOT EXISTS (
                      SELECT 1
                      FROM Reservations r
                      WHERE r.tableId = t.tableId
                        AND r.status != 'CANCELLED'
                        AND TO_DATE('{ReservationDateStart}', 'DD-MM-YYYY HH24:MI') < r.reservationDateTimeEnd
                        AND TO_DATE('{ReservationDateEnd}', 'DD-MM-YYYY HH24:MI') > r.reservationDateTimeStart
                    )
                ORDER BY t.Capacity";
                return Database.ExecuteMultiRowQuery(sql);
            }
            catch (Exception ex)
            {
                throw new Exception($"[Reservation.GetAvailableTables] Error finding tables for {GuestCount} guests. \nStart: {ReservationDateStart} \nMessage: {ex.Message}");
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
                SELECT t.TABLENO, t.Capacity, r.TableId, r.CUSTOMERNAME,  r.CUSTOMERPHONE, r.RESERVATIONDATETIMESTART, r.NUMBEROFGUESTS, r.RESERVATIONID, r.STATUS
                FROM RESERVATIONS r
                JOIN tablesinfo t ON r.TABLEID = t.TableId
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
                throw new Exception($"[Reservation.GetDetails] Search failed. Parameters: ID={id}, Phone={phone}, Name={name}. \nMessage: {ex.Message}");
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
                    NUMBEROFGUESTS = {GuestCount},
                    TABLEID = {TableId},
                    STATUS = '{Status}'
                WHERE RESERVATIONID = {ReservationId}";


                Database.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                throw new Exception($"[Reservation.UpdateDetails] Failed to update reservation #{ReservationId} \nMessage: {ex.Message}");
            }
        }

        public void AddReservation()
        {
            try
            {

                string sql = $@"
                INSERT INTO Reservations(tableId, customerName, customerPhone, reservationDateTimeStart, reservationDateTimeEnd, numberOfGuests, status)
                Values({TableId}, '{CustomerName}', '{CustomerPhone}', TO_DATE('{ReservationDateStart}', 'DD-MM-YYYY HH24:MI'), TO_DATE('{ReservationDateEnd}', 'DD-MM-YYYY HH24:MI'), {GuestCount}, 'BOOKED')
                ";

                Database.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                throw new Exception($"[Reservation.AddReservation] \nMessage: {ex.Message}");
            }
        }
    }
}