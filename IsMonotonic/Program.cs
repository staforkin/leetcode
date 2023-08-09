var solution = new Solution();
Console.WriteLine(solution.IsMonotonic(new[] { 1, 2, 2, 3 }));

// https://leetcode.com/problems/monotonic-array/
public class Solution
{
    public bool IsMonotonic(int[] nums)
    {
        var inc = true;
        var dec = true;
        for (int i = 1; i < nums.Length; ++i)
        {
            inc &= nums[i - 1] <= nums[i];
            dec &= nums[i - 1] >= nums[i];
        }
        return inc || dec;
    }
}