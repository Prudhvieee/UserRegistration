using RegexPatterns;
using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to user registration problem");
            Patterns patterns = new Patterns();
            //reads first name from user
            Console.WriteLine("Enter first Name");
            Console.WriteLine(patterns.ValidateName(Console.ReadLine()));
            //reads last name from user
            Console.WriteLine("Enter last Name");
            Console.WriteLine(patterns.ValidateName(Console.ReadLine()));
            //reads email from user
            Console.WriteLine("Enter mail");
            Console.WriteLine(patterns.ValidateEmail(Console.ReadLine()));
            //reads mobile number from user
            Console.WriteLine("Enter Mobile number");
            Console.WriteLine(patterns.ValidateMobileNumber(Console.ReadLine()));
            //reads password from user
            Console.WriteLine("Enter Password (minimum 8 characters)");
            Console.WriteLine(patterns.ValidatePassword(Console.ReadLine()));
        }
    }
}
