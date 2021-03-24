using System;
using System.Text.RegularExpressions;

namespace is_palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = "A man, a plan, a canal: Panama";
            Console.Write(IsPalindrome(s));
        }

        private static bool IsPalindrome(string s)
        {
            Regex rgx = new Regex("[^a-zA-Z0-9]");
            s = rgx.Replace(s, "").ToLower();
            var length = s.Length;
            for (int i = 0; i < length/2; i++)
            {
                if(s[i]!=s[length-i-1])
                {return false;}
            }
            return true;
        }
    }
}
