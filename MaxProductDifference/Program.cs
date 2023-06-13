var solution = new Solution();
Console.WriteLine(solution.MaxProductDifference(new[] { 5, 6, 2, 7, 4 }));

// https://leetcode.com/problems/maximum-product-difference-between-two-pairs
public class Solution
{
    public int MaxProductDifference(int[] nums)
    {
        // 5 6 2 7 2
        Array.Sort(nums);
        var n = nums.Length;
        return nums[n - 1] * nums[n - 2] - nums[0] * nums[1];
    }
}