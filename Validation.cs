using System;
using System.Collections.Generic;
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
            //if (string.IsNullOrWhiteSpace(name))
            //    return "Name is required.";

            //foreach (char c in name)
            //{
            //    if (!char.IsLetter(c) && c != ' ')
            //        return "Name must contain only letters.";
            //}

            //return "valid";

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
            //if (string.IsNullOrWhiteSpace(phone))
            //    return "Phone number is required.";

            //int digitCount = 0;
            //int startIndex = 0;

            //if (phone[0] == '+')
            //{
            //    startIndex = 1;
            //}

            //for (int i = startIndex; i < phone.Length; i++)
            //{
            //    if (!char.IsDigit(phone[i]))
            //        return "Phone number must contain only digits (after +).";

            //    digitCount++;
            //}

            //if (digitCount < 7 || digitCount > 15)
            //    return "Phone number must contain 7–15 digits.";

            //return "valid";


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

        public static string IsGuestsValid(decimal num)
        {
            if (num <= 0)
                return "Number of guests must be greater than 0.";

            if (num > 20)
                return "Number of guests exceeds restaurant limit (max 20).";

            return "Valid";
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
            if (combo.SelectedIndex == -1 || string.IsNullOrWhiteSpace(combo.Text))
                return $"{fieldName} must be selected.";

            return "Valid";
        }

        public static string IsGridSelected(DataGridView dataGrid, string fieldName)
        {
            if (dataGrid.SelectedRows.Count == 0)
                return $"{fieldName} must be selected.";

            return "Valid";
        }


        public static string IsGridSelected(DataGridView grid)
        {
            if (grid == null)
                return "Grid is not initialized.";

            if (grid.SelectedRows.Count == 0)
                return "Please select a reservation first.";

            return "Valid";
        }

        public static string IsSeatingCapacityValid(decimal num)
        {
            if (num <= 0)
                return "Seating capacity must be at least 1.";

            if (num > 20)
                return "Seating capacity cannot exceed 20.";

            return "Valid";
        }
        public static string IsTableNumberValid(decimal tableNo)
        {

            if (tableNo == 0)
                return "Table number must be greater tahn zero.";


            return "Valid";
        }

        public static void UpdateTotal(DataGridView gridView, Label label)
        {
            decimal total = 0;

            foreach (DataGridViewRow row in gridView.Rows)
            {
                total += Convert.ToDecimal(row.Cells["Subtotal"].Value);
            }

            label.Text = "€" + total.ToString("F2");
        }



    }
}

