using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RestaurantOrderingSystem
{
    public static class Validation
    {
        public static string IsNameValid(string name)
        {
            name = name.Trim();

            string pattern = @"^[A-Za-z]+( [A-Za-z]+)*$";
            Regex reg = new Regex(pattern);
            Match match = reg.Match(name);
            if (match.Success)
            {
                return "Valid";
            }
            else
            {
                return "Invalid name. Example of valid format: John Brosnan";
            }

        }

        public static string IsPhoneValid(string phone)
        {
            phone = phone.Trim();
            string pattern = @"^\+?\d{10,15}$";
            Regex reg = new Regex(pattern);
            Match match = reg.Match(phone);
            if (match.Success)
            {
                return "Valid";
            }
            else
            {
                return "Invalid phone number. Example of valid format: +1234567890";
            }
        }


        public static string IsEmailValid(string email)
        {
            email = email.Trim();
            string pattern = "^[^@\\s]+@[^@\\s]+\\.[^@\\s]+$";
            Regex reg = new Regex(pattern);
            Match match = reg.Match(email);
            if (match.Success)
            {
                return "Valid";
            }
            else
            {
                return "Invalid email address. Example of valid format: example@domain.com";
            }
        }

        public static string IsDateValid(DateTime date, DateTime time)
        {
            DateTime reservationDateTime = date.Date + time.TimeOfDay;
            DateTime now = DateTime.Now;

            if (reservationDateTime <= now)
            {
                return "Reservation date and time must be in the future";
            }

            return "Valid";
        }

        public static string IsComboBoxSelected(ComboBox combo, string fieldName)
        {
            if (combo == null || combo.SelectedIndex == -1 || string.IsNullOrWhiteSpace(combo.Text))
                return $"{fieldName} must be selected.";

            return "Valid";
        }

        public static string IsGridSelected(DataGridView grid, string fieldName = "Item")
        {
            if (grid == null) return "Grid is not initialized.";

            if (grid.SelectedRows.Count == 0)
                return $"Please select a {fieldName.ToLower()} first.";

            return "Valid";
        }

        public static string IsSeatingCapacityValid(decimal num)
        {
            if (num.Equals("")) return "Please enter the number of guests.";
            if (num <= 0) return "The number of guests must be at least 1.";
            if (num > 20) return "Our largest table can accommodate up to 20 guests. For larger groups, please contact us directly.";
            return "Valid";
        }

       

        public static string IsReservationTimeValid(DateTime selectedStart)
        {
            int hour = selectedStart.Hour;
            if (hour < 8 || hour >= 23)
            {
                return "Reservations are only available between 08:00 and 23:00.";
            }
            return "Valid";
        }
               
 

        public static decimal GetTotalAmount(DataGridView gridView)
        {
            decimal total = 0;

            foreach (DataGridViewRow row in gridView.Rows)
            {
                total += Convert.ToDecimal(row.Cells["Subtotal"].Value);
            }

            return total;
        }



    }
}

