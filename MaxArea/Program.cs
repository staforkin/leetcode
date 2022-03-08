using System;

namespace MaxArea
{
    class Program
    {
        //https://leetcode.com/problems/container-with-most-water
        static void Main(string[] args)
        {
            var solution = new Solution();
            Console.WriteLine(solution.MaxArea(new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }));
        }
    }

    public class Solution
    {
        public int MaxArea(int[] height)
        {
            int left = 0, right = height.Length - 1;
            int maxArea = 0;

            while (left < right)
            {
                maxArea = Math.Max(maxArea, Math.Min(height[left], height[right])
                        * (right - left));
                if (height[left] < height[right])
                    left++;
                else
                    right--;
            }

            return maxArea;
        }
    }
}
