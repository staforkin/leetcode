var solution = new Solution();
Console.WriteLine(solution.ClosestMeetingNode(new[] { 2, 2, 3, -1 }, 0, 1));

// https://leetcode.com/problems/find-closest-node-to-given-two-nodes
public class Solution
{
    public int ClosestMeetingNode(int[] edges, int node1, int node2)
    {
        int res = -1, min_dist = Int32.MaxValue;
        var m1 = new int[edges.Length];
        var m2 = new int[edges.Length];
        for (int i = 0; i < edges.Length; i++)
        {
            m1[i] = -1;
            m2[i] = -1;
        }

        for (int i = node1, dist = 0; i != -1 && m1[i] == -1; i = edges[i])
        { m1[i] = dist++; }
        for (int i = node2, dist = 0; i != -1 && m2[i] == -1; i = edges[i])
        {
            m2[i] = dist++;
            if (m1[i] >= 0 && Math.Max(m1[i], m2[i]) <= min_dist)
            {
                res = Math.Max(m1[i], m2[i]) == min_dist ? Math.Min(i, res) : i;
                min_dist = Math.Max(m1[i], m2[i]);
            }
        }
        return res;
    }
}