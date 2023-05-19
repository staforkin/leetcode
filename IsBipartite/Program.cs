var solution = new Solution();
var graph = new int[][] { new int[] { 1, 2, 3 }, new int[] { 0, 2 }, new int[] { 0, 1, 3 }, new int[] { 0, 2 } };
Console.WriteLine(solution.IsBipartite(graph));

// https://leetcode.com/problems/is-graph-bipartite
public class Solution
{
    public bool IsBipartite(int[][] graph)
    {
        int n = graph.Length;
        int[] colors = new int[n];

        for (int i = 0; i < n; i++) //This graph might be a disconnected graph. So check each unvisited node.
        {
            if (colors[i] == 0 && !validColor(graph, colors, 1, i))
            {
                return false;
            }
        }
        return true;
    }

    public bool validColor(int[][] graph, int[] colors, int color, int node)
    {
        if (colors[node] != 0)
        {
            return colors[node] == color;
        }
        colors[node] = color;
        foreach (int next in graph[node])
        {
            if (!validColor(graph, colors, -color, next))
            {
                return false;
            }
        }
        return true;
    }
}