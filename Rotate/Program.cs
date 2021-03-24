using System;

namespace rotate_array
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var nums = new[] { 1, 2, 3, 4, 5, 6, 7 };
            Rotate(nums, 3);
            foreach (var item in nums)
            {
                Console.Write(item);
            }
        }

        public static void Rotate(int[] nums, int k)
        {
            k %= nums.Length;
            reverse(nums, 0, nums.Length - 1);
            reverse(nums, 0, k - 1);
            reverse(nums, k, nums.Length - 1);
        }

        public static void reverse(int[] nums, int start, int end)
        {
            while (start < end)
            {
                int temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
                start++;
                end--;
            }
        }
    }
}