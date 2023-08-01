using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexRegistration
{
    class UserRegistration
    {
        public static void UserPassword()
        {
            string password = "Password@123"; 

            string pattern = @"^(?=.*[A-Z])(?=.*\d).{8,}$";
            bool isValid = Regex.IsMatch(password, pattern);

            Console.WriteLine($"Password is {password},Valid {isValid}");
        }
    }
}
