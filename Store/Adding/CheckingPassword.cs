using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Adding
{
    public class CheckingPassword
    {
        public static string CheckingPW(string password)
        {
            int secureLevel = 0;
            if (ContainsLowerLetter(password)) secureLevel++;
            if (ContainsUpperLetter(password)) secureLevel++;
            if (ContainsDigit(password)) secureLevel++;
            if (ContainsPunctuation(password)) secureLevel++;

            switch (secureLevel)
            {
                case 1:
                    return "Too week";
                case 2:
                    return "Could be strong";
                case 3:
                    return "Could be strong";
                case 4:
                    return "Strong password";
                default:
                    return "Checking password";
            }
        }

        static bool ContainsLowerLetter(string pass)
        {
            foreach (char c in pass)
            {
                if ((Char.IsLetter(c)) && (Char.IsLower(c)))
                    return true;
            }
            return false;
        }

        static bool ContainsUpperLetter(string pass)
        {
            foreach (char c in pass)
            {
                if ((Char.IsLetter(c)) && (Char.IsUpper(c)))
                    return true;
            }
            return false;
        }

        static bool ContainsDigit(string pass)
        {
            foreach (char c in pass)
            {
                if (Char.IsDigit(c))
                    return true;
            }
            return false;
        }

        static bool ContainsPunctuation(string pass)
        {
            foreach (char c in pass)
            {
                if (Char.IsPunctuation(c))
                    return true;
            }
            return false;
        }
    }
}
