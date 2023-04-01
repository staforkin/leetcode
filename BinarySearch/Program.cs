var solution = new Solution();
Console.WriteLine(solution.Search(new[] { -1, 0, 3, 5, 9, 12 }, 9));
Console.WriteLine(solution.Search(new[] { -1, 0, 3, 5, 9, 12 }, 2));

// https://leetcode.com/problems/binary-search
public class Solution
{
    public int Search(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;
        while (left < right)
        {
            var mid = left + (right - left + 1) / 2;
            if (target < nums[mid])
            {
                right = mid - 1;
            }
            else
            {
                left = mid;
            }
        }
        return nums[left] == target ? left : -1;
    }
}