using System;

namespace IsMatch
{
    class Program
    {
        //https://leetcode.com/problems/regular-expression-matching/
        static void Main(string[] args)
        {
            var solution = new Solution();
            Console.WriteLine(solution.IsMatch("aab", "c*a*b"));
        }
    }

    public class Solution
    {
        public bool IsMatch(string s, string p)
        {
            if (p == null || p.Length == 0) return (s == null || s.Length == 0);

            bool[,] dp = new bool[(s.Length + 1),(p.Length + 1)];
            dp[0,0] = true;
            for (int j = 2; j <= p.Length; j++)
            {
                dp[0,j] = p[j - 1] == '*' && dp[0,j - 2];
            }

            for (int j = 1; j <= p.Length; j++)
            {
                for (int i = 1; i <= s.Length; i++)
                {
                    if (p[j - 1] == s[i - 1] || p[j - 1] == '.')
                        dp[i,j] = dp[i - 1,j - 1];
                    else if (p[j - 1] == '*')
                        dp[i,j] = dp[i,j - 2] || ((s[i - 1] == p[j - 2] || p[j - 2] == '.') && dp[i - 1,j]);
                }
            }
            return dp[s.Length,p.Length];
        }
    }
}
