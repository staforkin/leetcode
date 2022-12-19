var solution = new Solution();
var arr = new int[][] { new[] { 2, 9 }, new[] { 7, 8 }, new[] { 5, 9 }, new[] { 7, 2 }
, new[] { 3, 8 }, new[] { 2, 8 }, new[] { 1, 6 }, new[] { 3, 0 }, new[] { 7, 0 }, new[] { 8, 5 }};
Console.WriteLine(solution.ValidPath(10, arr, 0, 1));

// https://leetcode.com/problems/find-if-path-exists-in-graph
public class Solution
{
    public bool ValidPath(int n, int[][] edges, int source, int destination)
    {
        // 0 -> 1 -> 2 -> 3 -> 0
        if (n == 0)
        {
            return true;
        }
        var dict = new Dictionary<int, List<int>>();
        foreach (var item in edges)
        {
            if (dict.ContainsKey(item[0]))
            {
                dict[item[0]].Add(item[1]);
            }
            else
            {
                dict.Add(item[0], new List<int>() { item[1] });
            }
            if (dict.ContainsKey(item[1]))
            {
                dict[item[1]].Add(item[0]);
            }
            else
            {
                dict.Add(item[1], new List<int>() { item[0] });
            }
        }
        var visited = new bool[n];
        var queue = new Queue<int>();
        queue.Enqueue(source);
        visited[source] = true;
        while (queue.Any())
        {
            int current = queue.Dequeue();
            if (current == destination)
            {
                return true;
            }
            foreach (var node in dict[current])
            {
                if (!visited[node])
                {
                    visited[node] = true;
                    queue.Enqueue(node);
                }
            }
        }
        return false;
    }
}