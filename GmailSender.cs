using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderingSystem
{
    using System.Net;
    using System.Net.Mail;

    public class GmailSender
    {

        // Replace with your actual Gmail address and the generated App Password
   

        public static void SendEmail(string fromAddress, string fromPassword, string toAddress, string subject, string body)
        {
            // Use the 16-character App Password here
            string senderPassword = fromPassword;

            var from = new MailAddress(fromAddress, "Morry Restaurant"); // Optional: Set display name
            var to = new MailAddress(toAddress);

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 465, //465  587
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress, senderPassword)
            };

            using (var message = new MailMessage(from, to)
            {
                Subject = subject,
                Body = body,
                IsBodyHtml = true // Set to true if your body contains HTML
            })
            {
                try
                {
                    smtp.Send(message);
                    Console.WriteLine("Email sent successfully!");
                }
                catch (SmtpException ex)
                {
                    Console.WriteLine("Status Code: " + ex.StatusCode);
                    Console.WriteLine("Full Error: " + ex.ToString());
                }
            }
        }


        

    }



}
