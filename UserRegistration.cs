using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexRegistration
{
    class UserRegistration
    {
        public static void UserPhoneNumber()
        {
            string phoneNumber = "91 9919819801"; 

            string pattern = @"^91 \d{10}$";
            bool isValid = Regex.IsMatch(phoneNumber, pattern);

            Console.WriteLine($"Phone Number is {phoneNumber},Valid {isValid}");
        }
    }
}
