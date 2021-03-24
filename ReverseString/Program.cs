using System;

namespace reverse_string
{
    class Program
    {
        public static void Main(string[] args)
        {
            var chars = new[]{'h','e','l','l', 'o'};
            ReverseString(chars);
            foreach (var item in chars)
            {
                Console.Write(item);
            }
        }

        private static void ReverseString(char[] s)
        {
            var length = s.Length;
            for (int i = 0; i < length/2; i++)
            {
                var t = s[i];
                s[i] = s[length-1-i];
                s[length-1-i] = t;                
            }
        }
    }
}
