var solution = new Solution();
Console.WriteLine(solution.SearchInsert(new[] { 1, 3, 5, 6 }, 4));

// https://leetcode.com/problems/search-insert-position
public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        // 0 1 2 3
        // 1 3 5 6
        // n = 4
        // mid = 2
        int left = 0;
        int right = nums.Length - 1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (nums[mid] == target)
            {
                return mid;
            }
            else if (nums[mid] > target)
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }
        return left;
    }
}