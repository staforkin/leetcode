using System;

namespace ValidPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ValidPalindromeImpl("lcupuupucul"));
        }

        private static bool ValidPalindromeImpl(string s)
        {
            // i   j
            // abvba
            // l = 5
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                {
                    int j = s.Length - 1 - i;
                    return (isPalindromeRange(s, i + 1, j) ||
                            isPalindromeRange(s, i, j - 1));
                }
            }
            return true;
        }

        public static bool isPalindromeRange(String s, int i, int j)
        {
            for (int k = i; k <= i + (j - i) / 2; k++)
            {
                if (s[k] != s[j - k + i]) return false;
            }
            return true;
        }
    }
}
