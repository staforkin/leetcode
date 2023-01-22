var solution = new Solution();
foreach (var item in solution.CombinationSum2(new[] { 10, 1, 2, 7, 6, 1, 5 }, 8))
{
    Console.WriteLine(string.Join(",", item));
}

// https://leetcode.com/problems/combination-sum-ii
public class Solution
{
    public IList<IList<int>> CombinationSum2(int[] candidates, int target)
    {

    }
}