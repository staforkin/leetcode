var solution = new Solution();
Console.WriteLine(string.Join(",", solution.FindSmallestSetOfVertices(6, new[] { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 2, 5 }, new[] { 3, 4 }, new[] { 4, 2 } })));

// https://leetcode.com/problems/minimum-number-of-vertices-to-reach-all-nodes
public class Solution
{
    public IList<int> FindSmallestSetOfVertices(int n, IList<IList<int>> edges)
    {
        var res = new List<int>();
        int[] seen = new int[n];
        foreach (var e in edges)
        {
            seen[e[1]] = 1;
        }
        for (int i = 0; i < n; ++i)
        {
            if (seen[i] == 0)
            {
                res.Add(i);
            }
        }
        return res;
    }
}