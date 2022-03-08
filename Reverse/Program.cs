using System;
using System.Text;

namespace Reverse
{
    class Program
    {
        //https://leetcode.com/problems/reverse-integer/
        static void Main(string[] args)
        {
            var solution = new Solution();
            Console.WriteLine(solution.Reverse(-123));
        }
    }

    public class Solution
    {
        public int Reverse(int x)
        {
            //123456
            var sb = new StringBuilder();
            if(x<0){
                sb.Append("-");
                x*=(-1);
            }
            do
            {
                sb.Append(x % 10);
                x = x / 10;
            } while (x > 0);
            int res = 0;
            int.TryParse(sb.ToString(), out res);
            return res;
        }
    }
}
