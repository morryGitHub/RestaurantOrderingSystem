using RestaurantOrderingSystem.OracleDatabase;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderingSystem
{
    internal class Payment
    {
        private int PaymentID;
        private int OrderID;
        private decimal Amount;
        private string MethodType;
        private string PaymentDate;
        private string Status;

        public Payment(int orderID, decimal amount, string methodType, string paymentDate)
        {
            OrderID = orderID;
            Amount = amount;
            MethodType = methodType;
            PaymentDate = paymentDate;
        }

        public void MakePayment()
        {
            string sql = $@"
                    BEGIN 

                        INSERT INTO PAYMENTS(orderID, amount, methodType, paymentDate)
                        VALUES({OrderID},{Amount},'{MethodType}',TO_DATE('{PaymentDate}', 'DD-MM-YYYY HH24:MI'));

                        UPDATE ORDERS
                        SET STATUS = 'Completed'
                        WHERE OrderID = {OrderID};
                    
                    END;
                ";

            Database.ExecuteNonQuery(sql);
        }
    }
}
