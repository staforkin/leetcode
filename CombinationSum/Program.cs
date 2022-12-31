var solution = new Solution();
foreach (var item in solution.CombinationSum(new[] { 2, 3, 5 }, 8))
{
    Console.WriteLine(string.Join(",", item));
}

// https://leetcode.com/problems/combination-sum/
public class Solution
{
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {

    }
}