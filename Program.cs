﻿using RegexPatterns;
using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wlcome to user registration problem");
            Patterns patterns = new Patterns();
           //Console.WriteLine("Enter first Name");
           //Console.WriteLine(patterns.ValidateFirstName(Console.ReadLine()));
          //Console.WriteLine("Enter last Name");
           //Console.WriteLine(patterns.ValidateLastName(Console.ReadLine()));
            Console.WriteLine("Enter mail");
            Console.WriteLine(patterns.ValidateEmail(Console.ReadLine()));
            //Console.WriteLine("Enter Mobile number");
            //Console.WriteLine(patterns.ValidateMobileNumber(Console.ReadLine()));
            //Console.WriteLine("Enter Password (minimum 8 characters)");
            //Console.WriteLine(patterns.ValidatePassword(Console.ReadLine()));
        }
    }
}
