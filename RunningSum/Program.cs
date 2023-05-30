var solution = new Solution();
Console.WriteLine(string.Join(",", solution.RunningSum(new[] { 1, 2, 3, 4 })));

// https://leetcode.com/problems/running-sum-of-1d-array
public class Solution
{
    public int[] RunningSum(int[] nums)
    {
        var res = new int[nums.Length];
        res[0] = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            res[i] = res[i - 1] + nums[i];
        }
        return res;
    }
}