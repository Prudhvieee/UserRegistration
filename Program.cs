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
            Console.WriteLine("Enter first Name");
            Console.WriteLine(patterns.ValidateFirstName(Console.ReadLine()));
        }
    }
}
