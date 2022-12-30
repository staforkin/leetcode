var solution = new Solution();
var arr = new int[][] { new int[] { 1, 2 }, new int[] { 3 }, new int[] { 3 }, new int[] { } };
foreach (var item in solution.AllPathsSourceTarget(arr))
{
    Console.WriteLine(string.Join(",", item));
}

// https://leetcode.com/problems/all-paths-from-source-to-target
public class Solution
{
    public IList<IList<int>> AllPathsSourceTarget(int[][] graph)
    {

    }
}