var solution = new Solution();
Console.WriteLine(solution.Search(new[] { 4, 5, 6, 7, 0, 1, 2 }, 0) + " expected 4");//k = 3
Console.WriteLine(solution.Search(new[] { 4, 5, 6, 7, 0, 1, 2 }, 6) + " expected 2");//k = 3

//https://leetcode.com/problems/search-in-rotated-sorted-array/
public class Solution
{
    public int Search(int[] nums, int target)
    {
        var length = nums.Length;//7
        if (length == 1)
        {
            return nums[0] == target ? 0 : -1;
        }
        //find k
        //       |
        // 0 1 2 3 4 5 6
        // 4 5 6 7 0 1 2
        var right = length - 1;
        var left = 0;
        while (left < right)
        {
            int mid = (left + right) / 2;
            if (nums[mid] > nums[right])
            {
                left = mid + 1;
            }
            else
            {
                right = mid;
            }
        }
        var k = left;
        left = 0; right = length - 1;
        while (left <= right)
        {
            int mid = (left + right) / 2;
            int realMid = (mid + k) % length;
            if (nums[realMid] == target)
            {
                return realMid;
            }
            if (nums[realMid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return -1;
    }
}