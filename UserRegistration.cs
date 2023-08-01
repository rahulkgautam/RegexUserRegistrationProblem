using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexRegistration
{
    class UserRegistration
    {
        public static void UserFirstName()
        {
            string firstName = "Rahul";

            string pattern = @"^[A-Z][a-zA-Z]{2,}$";
            bool isValid = Regex.IsMatch(firstName, pattern);

            Console.WriteLine($"First Name is {firstName},Valid {isValid}");
        }
    }
}
