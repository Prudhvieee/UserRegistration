using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace RegexPatterns
{
    public class Patterns
    {
        //regex pattern for first name
        public static string REGEX_NAME = "^[A-Z]{1}[A-Za-z]{2,}$";
        //regex pattern for MAIL
        public static string REGEX_EMAIL = "^[a-zA-Z0-9_+&*-]+(?:\\." +"[a-zA-Z0-9_+&*-]+)*@" +
                                      "(?:[a-zA-Z0-9-]+\\.)+[a-z" +"A-Z]{2,7}$";
        //regex pattern for mobile number
        public static string REGEX_MOBILENUMBER = "^[1-9]{2}"+"\\s([0-9]{10})$";
        //regex pattern for Password
        public static string REGEX_PASSWORD = "(?=.*?[._+-@#&*$])(?=.*[A-Z])(?=.*[0-9])([0-9a-zA-z]{7,})";
        /// <summary>
        /// validates firstname
        /// </summary>
        /// <param name="firstName"></param>
        /// <returns></returns>
        public bool ValidateName(string name)
        {
            return Regex.IsMatch(name, REGEX_NAME);
        }
        /// <summary>
        /// validates email
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, REGEX_EMAIL);
        }
        /// <summary>
        /// validates mobile number
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public bool ValidateMobileNumber(string number)
        {
            return Regex.IsMatch(number, REGEX_MOBILENUMBER);
        }
        /// <summary>
        /// validates password
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool ValidatePassword(string password)
        {
            return Regex.IsMatch(password, REGEX_PASSWORD);
        }
    }
}