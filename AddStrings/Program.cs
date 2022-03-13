using System;
using System.Text;

namespace AddStrings
{
    class Program
    {
        //https://leetcode.com/problems/add-strings/
        static void Main(string[] args)
        {
            var solution = new Solution();
            Console.WriteLine(solution.AddStrings("999", "1"));
        }
    }

    public class Solution
    {
        public string AddStrings(string num1, string num2)
        {
            var sb = new StringBuilder();
            string t1 = num1.Length >= num2.Length ? num1 : num2;
            string t2 = num1.Length >= num2.Length ? num2 : num1;

            var l1 = t1.Length;
            var l2 = t2.Length;
            int overflow = 0;
            int j = l2 - 1;
            for (int i = l1 - 1; i > -2; i--)
            {
                int ii = 0;
                int jj = 0;
                if (i > -1)
                {
                    ii = int.Parse(new[] { t1[i] });
                }
                else if (overflow == 0)
                {
                    break;
                }
                if (j > -1)
                {
                    jj = int.Parse(new[] { t2[j] });
                }
                int tt = ii + jj + overflow;
                if (tt > 9)
                {
                    overflow = 1;
                    tt = tt - 10;
                }
                else { overflow = 0; }
                sb.Append(tt);
                j--;
            }
            var arr = sb.ToString().ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
