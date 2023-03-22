var solution = new Solution();
var roads = new int[][] {
    new int[] { 1, 2, 9 },
    new int[] { 2, 3, 6 },
    new int[] { 2, 4, 5 },
    new int[] { 1, 4, 7 } };
Console.WriteLine(solution.MinScore(4, roads));

// https://leetcode.com/problems/minimum-score-of-a-path-between-two-cities
public class Solution
{
    public int MinScore(int n, int[][] roads)
    {
        int ans = int.MaxValue;
        var gr = new List<List<(int, int)>>();
        for (int i = 0; i < n + 1; i++)
        {
            gr.Add(new List<(int, int)>());
        }

        foreach (int[] edge in roads)
        {
            gr[edge[0]].Add(new (edge[1], edge[2])); // u-> {v, dis}
            gr[edge[1]].Add(new (edge[0], edge[2])); // v-> {u, dis}
        }

        int[] vis = new int[n + 1];
        Array.Fill(vis, 0);
        var q = new Queue<int>();
        q.Enqueue(1);
        vis[1] = 1;
        while (q.Any())
        {
            int node = q.Dequeue();
            foreach (var pair in gr[node])
            {
                int v = pair.Item1;
                int dis = pair.Item2;
                ans = Math.Min(ans, dis);
                if (vis[v] == 0)
                {
                    vis[v] = 1;
                    q.Enqueue(v);
                }
            }
        }

        return ans;
    }
}