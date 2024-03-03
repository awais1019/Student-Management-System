using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MidProjectEven.Classes
{
    internal class Validations
    {
        public static bool ValidName(string name)
        {
            return !string.IsNullOrEmpty(name) && name.Length >= 3;
        }

        public static bool ValidEmail(string email)
        {
           
            string pattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            Regex regex = new Regex(pattern);

            return !string.IsNullOrEmpty(email) && regex.IsMatch(email);
        }

        public static bool ValidContact(string contact)
        {
            return !string.IsNullOrEmpty(contact) && contact.Length == 11 && contact.All(char.IsDigit);
        }
        public static bool ValidRegistrationNumber(string regNumber)
        {
            string pattern = @"^\d{4}-[a-zA-Z]{2,}-\d{3,}$";
            Regex regex = new Regex(pattern);
            return !string.IsNullOrEmpty(regNumber) && regex.IsMatch(regNumber);
        }

    }
}
