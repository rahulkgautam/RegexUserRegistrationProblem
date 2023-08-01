using System;
using System.Text.RegularExpressions;

namespace RegexRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regex Registration Problem...");
            // UserRegistration.UserPassword();

            string[] emailSamples = {
            "abc@yahoo.com",
            "abc-100@yahoo.com",
            "abc.100@yahoo.com",
            "abc111@abc.com",
            "abc-100@abc.net",
            "abc.100@abc.com.au",
            "abc@1.com",
            "abc@gmail.com.com",
            "abc+100@gmail.com",

            "abc @gmail","abc123@.com",
            "abc123@.com.com ",
            "abc@abc.com",
            "abc()*@gmail.com",
            "abc@%*.com",
            "abc..2002@gmail.com",
            "abc.@gmail.com",
            "abc@abc@gmail.com",
            "abc@gmail.com.1a",
            "abc@gmail.com.aa.au"
        };

            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);

            foreach (string email in emailSamples)
            {
                bool isValid = regex.IsMatch(email);
                if (isValid)
                {
                    Console.WriteLine($"Valid email: {email}");
                }
                else
                {
                    Console.WriteLine($"Invalid email: {email}");
                }
            }
        }
    }
}
