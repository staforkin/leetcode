using System;

namespace two_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new[] { 3,2,3 };
            int target = 6;
            var result = TwoSum(nums, target);
            foreach (var item in result)
            {
                Console.Write(item);
            }
        }
        public static int[] TwoSum(int[] nums, int target)
        {
            var result = new int[2];
            for (int i = 0; i < nums.Length-1; i++)
            {
                var j = i+1;
                while(nums[i]+nums[j]!=target && j < nums.Length-1){
                    j++;
                }
                if(nums[i]+nums[j]==target) {
                    result = new int[]{i,j};
                    break;
                }
            }
            return result;
        }
    }
}
