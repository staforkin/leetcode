using System;
using System.Collections.Generic;

namespace first_uniq_char
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = "loveleetcode";
            int result = FirstUniqueChar(s);
            Console.Write(result);
        }

        private static int FirstUniqueChar(string s)
        {
            var dict = new Dictionary<char,int>();
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                dict[c] = dict.GetValueOrDefault(c)+1;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if(dict[s[i]]==1)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
