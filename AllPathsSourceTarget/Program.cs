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
        // 0 -> 1
        // |    |
        // v    v
        // 2 -> 3

        var res = new List<IList<int>>();
        var path = new List<int>();

        path.Add(0);
        dfsSearch(graph, 0, res, path);

        return res;
    }

    private void dfsSearch(int[][] graph, int node, List<IList<int>> res, List<int> path)
    {
        if (node == graph.Length - 1)
        {
            res.Add(new List<int>(path));
            return;
        }

        foreach (int nextNode in graph[node])
        {
            path.Add(nextNode);
            dfsSearch(graph, nextNode, res, path);
            path.RemoveAt(path.Count - 1);
        }
    }
}