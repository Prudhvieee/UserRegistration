﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace RegexPatterns
{
    class Patterns
    {
        public static string REGEX_FIRSTNAME = "^[A-Z]{1}[A-Za-z]{2,}$";
        public static string REGEX_LASTSTNAME = "^[A-Z]{1}[A-Za-z]{2,}$";
        public static string REGEX_EMAIL = "^[a-z.]{3,}"+"@([a-z.]{2,})$";
        public static string REGEX_MOBILENUMBER = "^[1-9]{2}"+"\\s([0-9]{10})$";
        public static string REGEX_PASSWORD = "(?=.*[A-Z])(?=.*[0-9])[a-zA-Z0-9]{6,}";

        public bool ValidateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, REGEX_FIRSTNAME);
        }
        public bool ValidateLastName(string lastName)
        {
            return Regex.IsMatch(lastName, REGEX_FIRSTNAME);
        }
        public bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, REGEX_EMAIL);
        }
        public bool ValidateMobileNumber(string number)
        {
            return Regex.IsMatch(number, REGEX_MOBILENUMBER);
        }
        public bool ValidatePassword(string password)
        {
            return Regex.IsMatch(password, REGEX_PASSWORD);
        }
    }
}