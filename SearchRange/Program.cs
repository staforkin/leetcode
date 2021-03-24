using System;

namespace SearchRange
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in SearchRangeImpl(new int[]{5,7,7,8,8,10}, 6))
            {
                Console.Write(item);
            }
        }

        private static int[] SearchRangeImpl(int[] nums, int target){
            int[] targetRange = {-1, -1};

        int leftIdx = extremeInsertionIndex(nums, target, true);

        // assert that `leftIdx` is within the array bounds and that `target`
        // is actually in `nums`.
        if (leftIdx == nums.length || nums[leftIdx] != target) {
            return targetRange;
        }

        targetRange[0] = leftIdx;
        targetRange[1] = extremeInsertionIndex(nums, target, false)-1;

        return targetRange;
        }

        private int extremeInsertionIndex(int[] nums, int target, bool left) {
        int lo = 0;
        int hi = nums.length;

        while (lo < hi) {
            int mid = (lo + hi) / 2;
            if (nums[mid] > target || (left && target == nums[mid])) {
                hi = mid;
            }
            else {
                lo = mid+1;
            }
        }

        return lo;
        }
    }
}
