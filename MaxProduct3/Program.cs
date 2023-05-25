var solution = new Solution();
Console.WriteLine(solution.MaxProduct(new[] { 3, 4, 5, 2 }));

// https://leetcode.com/problems/maximum-product-of-two-elements-in-an-array/
public class Solution
{
    public int MaxProduct(int[] nums)
    {
        Array.Sort(nums);
        var n = nums.Length;
        return (nums[n - 1] - 1) * (nums[n - 2] - 1);
    }
}