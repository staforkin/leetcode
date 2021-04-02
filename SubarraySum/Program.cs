using System;
using System.Collections.Generic;

namespace SubarraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Given an array of integers nums and an integer k, return the total number of continuous subarrays whose sum equals to k.
            Console.WriteLine(SubarraySumImpl(new[] { 1, -1, 0 }, 0));
        }

        private static int SubarraySumImpl(int[] nums, int k)
        {
            //i
            //1 1 1
            //j
            int sums = 0;
            if (k == 0)
            {
                //sums++;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                int t = 0;
                for (int j = i; j < nums.Length; j++)
                {
                    t += nums[j];
                    if (t == k)
                    {
                        sums++;
                    }
                }
            }
            return sums;
        }
    }
}
