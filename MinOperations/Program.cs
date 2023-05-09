var solution = new Solution();
Console.WriteLine(solution.MinOperations(new[] { 1, 1, 1 }));

// https://leetcode.com/problems/minimum-operations-to-make-the-array-increasing
public class Solution
{
    public int MinOperations(int[] nums)
    {
        int res = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i - 1] >= nums[i])
            {
                res += (nums[i - 1] + 1) - nums[i];
                nums[i] = nums[i - 1] + 1;
            }
        }
        return res;
    }
}