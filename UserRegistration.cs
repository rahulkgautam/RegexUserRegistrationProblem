using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexRegistration
{
    class UserRegistration
    {
        public static void UserLastName()
        {
            string lastName = "Gautam"; 

            string pattern = @"^[A-Z][a-zA-Z]{2,}$";
            bool isValid = Regex.IsMatch(lastName, pattern);

            Console.WriteLine($"Last Name is {lastName},Valid {isValid}");
        }
    }
}
