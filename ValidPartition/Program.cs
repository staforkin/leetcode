var solution = new Solution();
Console.WriteLine(solution.ValidPartition(new[] { 4, 4, 4, 5, 6 }));

// https://leetcode.com/problems/check-if-there-is-a-valid-partition-for-the-array/
public class Solution
{
    public bool ValidPartition(int[] nums)
    {
        var dp = new bool[4] { true, false, nums[0] == nums[1], false };
        for (int i = 2; i < nums.Length; ++i)
        {
            var two = nums[i] == nums[i - 1];
            var three = (two && nums[i] == nums[i - 2]) || (nums[i] - 1 == nums[i - 1] && nums[i] - 2 == nums[i - 2]);
            dp[(i + 1) % 4] = (two && dp[(i - 1) % 4]) || (three && dp[(i - 2) % 4]);
        }
        return dp[nums.Length % 4];
    }
}