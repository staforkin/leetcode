var solution = new Solution();
foreach (var item in solution.FindSubsequences(new int[] { 4, 6, 7, 7 }))
{
    Console.WriteLine(string.Join(",", item));
}

// https://leetcode.com/problems/non-decreasing-subsequences
public class Solution
{
    public IList<IList<int>> FindSubsequences(int[] nums)
    {

    }
}