var solution = new Solution();
var connections = new int[][] {
    new int[] { 0, 1 },
    new int[] { 1, 3 },
    new int[] { 2, 3 },
    new int[] { 4, 0 },
    new int[] { 4, 5 } };
Console.WriteLine(solution.MinReorder(6, connections));

// https://leetcode.com/problems/reorder-routes-to-make-all-paths-lead-to-the-city-zero
public class Solution
{
    public int MinReorder(int n, int[][] connections)
    {
        // 0 - 1
        // 1 - 3
        // 2 - 3
        // 4 - 0
        // 4 - 5

        var list = new List<List<int>>();
        for (int i = 0; i < n; ++i)
        {
            list.Add(new List<int>());
        }
        foreach (var c in connections)
        {
            list[c[0]].Add(c[1]);
            list[c[1]].Add(-c[0]);
        }
        return dfs(list, new bool[n], 0);
    }

    int dfs(List<List<int>> list, bool[] visited, int from)
    {
        int change = 0;
        visited[from] = true;
        foreach (var to in list[from])
        {
            if (!visited[Math.Abs(to)])
            {
                change += dfs(list, visited, Math.Abs(to)) + (to > 0 ? 1 : 0);
            }
        }
        return change;
    }
}