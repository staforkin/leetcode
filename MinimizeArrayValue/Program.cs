var solution = new Solution();
Console.WriteLine(solution.MinimizeArrayValue(new[] { 3, 7, 1, 6 }));

// https://leetcode.com/problems/minimize-maximum-of-array/
public class Solution
{
    public int MinimizeArrayValue(int[] nums)
    {
        long sum = 0, res = 0;
        for (int i = 0; i < nums.Length; ++i)
        {
            sum += nums[i];
            res = Math.Max(res, (sum + i) / (i + 1));
        }
        return (int)res;
    }
}