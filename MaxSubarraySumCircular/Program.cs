var solution = new Solution();
Console.WriteLine(solution.MaxSubarraySumCircular(new int[] { 5, -3, 5 }));

// https://leetcode.com/problems/maximum-sum-circular-subarray
public class Solution
{
    public int MaxSubarraySumCircular(int[] nums)
    {
        // 5 -3 5
        int total = 0, maxSum = nums[0], curMax = 0, minSum = nums[0], curMin = 0;
        foreach (var a in nums) {
            curMax = Math.Max(curMax + a, a);
            maxSum = Math.Max(maxSum, curMax);
            curMin = Math.Min(curMin + a, a);
            minSum = Math.Min(minSum, curMin);
            total += a;
        }
        return maxSum > 0 ? Math.Max(maxSum, total - minSum) : maxSum;
    }
}