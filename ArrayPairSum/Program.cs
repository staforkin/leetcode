var solution = new Solution();
Console.WriteLine(solution.ArrayPairSum(new[] { 1, 4, 3, 2 }));

// https://leetcode.com/problems/array-partition
public class Solution
{
    public int ArrayPairSum(int[] nums)
    {
        int res = default;
        Array.Sort(nums);
        for (int i = 0; i < nums.Length; i += 2)
        {
            res += nums[i];
        }
        return res;
    }
}