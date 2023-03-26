var solution = new Solution();
Console.WriteLine(solution.LongestCycle(new[] { 3, 3, 4, 2, 3 }));

// https://leetcode.com/problems/longest-cycle-in-a-graph
public class Solution
{
    public int LongestCycle(int[] edges)
    {
        int res = -1;
        var vis = new bool[edges.Length]; // global visisted

        for (int i = 0; i < edges.Length; i++)
        {
            if (vis[i])
            {
                continue;
            }
            var x = new Dictionary<int, int>();  // local visited
            for (int idx = i, dist = 0; idx != -1; idx = edges[idx])
            {
                if (x.ContainsKey(idx))
                {
                    res = Math.Max(res, dist - x[idx]);
                    break;
                }
                if (vis[idx])
                {
                    break;
                }
                vis[idx] = true;
                x.TryAdd(idx, dist++);
            }
        }
        return res;
    }
}