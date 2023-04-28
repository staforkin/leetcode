var solution = new Solution();
Console.WriteLine(string.Join(",", solution.GetConcatenation(new int[] { 1, 2, 1 })));

// https://leetcode.com/problems/concatenation-of-array
public class Solution
{
    public int[] GetConcatenation(int[] nums)
    {
        return nums.Concat(nums).ToArray();
    }
}