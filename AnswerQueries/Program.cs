var solution = new Solution();
Console.WriteLine(string.Join(",", solution.AnswerQueries(new[] { 4, 5, 2, 1 }, new[] { 3, 10, 21 })));

// https://leetcode.com/problems/longest-subsequence-with-limited-sum
public class Solution
{
    public int[] AnswerQueries(int[] nums, int[] queries)
    {
        Array.Sort(nums);
        int n = nums.Length, m = queries.Length;
        var res = new int[m];
        for (int i = 1; i < n; i++)
        {
            nums[i] += nums[i - 1]; // nums[i] is sum of original item + sum of all previous items in array
        }
        for (int i = 0; i < m; i++)
        {
            int j = Array.BinarySearch(nums, queries[i]);
            res[i] = Math.Abs(j + 1);
        }
        return res;
    }
}