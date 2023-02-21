var solution = new Solution();
Console.WriteLine(solution.SingleNonDuplicate(new[] { 1, 1, 2, 3, 3, 4, 4, 8, 8 }));

// https://leetcode.com/problems/single-element-in-a-sorted-array
public class Solution
{
    public int SingleNonDuplicate(int[] nums)
    {
        // 0 1 2 3 4 5 6 7 8
        // 1 1 2 3 3 4 4 8 8

        // 3 3 7 7 8 9 9
        int left = 0;
        int right = nums.Length - 1;
        int mid = default;
        while (left < right)
        {
            mid = (left + right) / 2;
            if ((mid % 2 == 0 && nums[mid] == nums[mid + 1]) || (mid % 2 == 1 && nums[mid] == nums[mid - 1]))
            {
                left = mid + 1;
            }
            else
            {
                right = mid;
            }
        }
        return nums[left];
    }
}