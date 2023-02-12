var solution = new Solution();
var roads = new int[][]{
    new int[]{0,1},
    new int[]{0,2},
    new int[]{0,3}
};
Console.WriteLine(solution.MinimumFuelCost(roads, 5));

// https://leetcode.com/problems/minimum-fuel-cost-to-report-to-the-capital
public class Solution
{
    long ans = 0; int s;
    public long MinimumFuelCost(int[][] roads, int seats)
    {
        var graph = new List<List<int>>(); s = seats;
        for (int i = 0; i < roads.Length + 1; i++)
        {
            graph.Add(new List<int>());
        }

        foreach (int[] r in roads)
        {
            graph[r[0]].Add(r[1]);
            graph[r[1]].Add(r[0]);
        }
        dfs(0, 0, graph);
        return ans;
    }

    private int dfs(int i, int prev, List<List<int>> graph)
    {
        int people = 1;
        foreach (int x in graph[i])
        {
            if (x == prev)
            {
                continue;
            }
            people += dfs(x, i, graph);
        }
        if (i != 0)
        {
            ans += (int)Math.Ceiling((double)people / s);
        }
        return people;
    }
}