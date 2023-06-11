var solution = new Solution();
Console.WriteLine(solution.MaxAscendingSum(new[] { 10, 20, 30, 5, 10, 50 }));

// https://leetcode.com/problems/maximum-ascending-subarray-sum/
public class Solution
{
    public int MaxAscendingSum(int[] nums)
    {
        // 10 20 30 5 10 50
        int maxSum = default;
        int tSum = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] < nums[i - 1])
            {
                maxSum = Math.Max(maxSum, tSum);
                tSum = nums[i];
            }
            else
            {
                tSum += nums[i];
            }
        }
        return Math.Max(tSum, maxSum);
    }
}