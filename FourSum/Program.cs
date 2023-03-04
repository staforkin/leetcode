var solution = new Solution();
foreach (var item in solution.FourSum(new[] { 1, 0, -1, 0, -2, 2 }, 0))
{
    Console.WriteLine(string.Join(",", item));
}

// https://leetcode.com/problems/4sum
public class Solution
{
    public IList<IList<int>> FourSum(int[] nums, int target)
    {

    }
}