var solution = new Solution();
var arr = new int[][] { new[] { 1, 2 }, new[] { 1, 3 }, new[] { 2, 4 } };
var arr2 = new int[][] { new[] { 1, 2 }, new[] { 2, 3 }, new[] { 3, 1 }, new[] { 4, 1 } };

Console.WriteLine(solution.PossibleBipartition(4, arr2));

// https://leetcode.com/problems/possible-bipartition/
public class Solution
{
    public bool PossibleBipartition(int n, int[][] dislikes)
    {
        // 1-2-4
        // |
        // 3
        // 
        //  1 - 2
        //  | \ |
        //  4   3
        var graph = new IList<int>[n + 1];

        for (int i = 1; i <= n; ++i)
        {
            graph[i] = new List<int>();
        }

        foreach (int[] dislike in dislikes)
        {
            graph[dislike[0]].Add(dislike[1]);
            graph[dislike[1]].Add(dislike[0]);
        }

        int[] colors = new int[n + 1];

        for (int i = 1; i <= n; ++i)
        {
            // If the connected component that node i belongs to hasn't been colored yet then try coloring it.
            if (colors[i] == 0 && !dfs(graph, colors, i, 1))
            {
                return false;
            }
        }
        return true;
    }

    private bool dfs(IList<int>[] graph, int[] colors, int currNode, int currColor)
    {
        colors[currNode] = currColor;

        // Color all uncolored adjacent nodes.
        foreach (int adjacentNode in graph[currNode])
        {

            if (colors[adjacentNode] == 0)
            {
                if (!dfs(graph, colors, adjacentNode, currColor * -1))
                {
                    return false;
                }
            }
            else if (colors[adjacentNode] == currColor)
            {
                // adjacent node is already colored with current color
                return false;
            }
        }
        return true;
    }
}