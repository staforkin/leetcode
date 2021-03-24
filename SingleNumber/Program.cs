using System;
using System.Linq;

namespace single_number
{
    class Program
    {
        public static void Main(string[] args)
        {
            var nums = new[] { 1, 1, 3, 2, 3 };
            Console.Write(SingleNumber(nums));
        }

        public static int SingleNumber(int[] nums)
        {
            return nums.GroupBy(i=>i).Where(i=>i.Count()==1).FirstOrDefault().Key;
        }
    }
}
