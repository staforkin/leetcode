var solution = new Solution();
Console.WriteLine(solution.MaxSubArray(new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }) + " expected 6");
Console.WriteLine(solution.MaxSubArray(new[] { 5, 4, -1, 7, 8 }) + " expected 23");
Console.WriteLine(solution.MaxSubArray(new[] { -1 }) + " expected -1");
Console.WriteLine(solution.MaxSubArray(new[] { -2, 1 }) + " expected 1");

//https://leetcode.com/problems/maximum-subarray
public class Solution
{
    public int MaxSubArray(int[] nums)
    {
        int maxSoFar = nums[0], maxEndingHere = nums[0];
        for (int i = 1; i < nums.Length; ++i)
        {
            maxEndingHere = Math.Max(maxEndingHere + nums[i], nums[i]);
            maxSoFar = Math.Max(maxSoFar, maxEndingHere);
        }
        return maxSoFar;
    }
}