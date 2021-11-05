using System;
using System.Linq;

namespace SumZero
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 5;
            Console.WriteLine(string.Join(";", SumZero(n)));
        }

        //https://leetcode.com/problems/find-n-unique-integers-sum-up-to-zero/
        public static int[] SumZero(int n)
        {
            var res = new int[n];
            int left = 0, right = n-1, start = 1;
            while(left<right){
                res[left++]=start;
                res[right--]=-start;
                start++;
            }
            return res;
        }
    }
}
