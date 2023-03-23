var solution = new Solution();
var connections = new int[][] { new int[] { 0, 1 }, new int[] { 0, 2 }, new int[] { 1, 2 } };
Console.WriteLine(solution.MakeConnected(4, connections));

// https://leetcode.com/problems/number-of-operations-to-make-network-connected
public class Solution
{
    public int MakeConnected(int n, int[][] connections)
    {
        if (connections.Length < n - 1)
        {
            return -1; // To connect all nodes need at least n-1 edges
        }
        int[] parent = new int[n];
        for (int i = 0; i < n; i++)
        {
            parent[i] = i;
        }
        int components = n;
        foreach (int[] c in connections)
        {
            int p1 = findParent(parent, c[0]);
            int p2 = findParent(parent, c[1]);
            if (p1 != p2)
            {
                parent[p1] = p2; // Union 2 component
                components--;
            }
        }
        return components - 1; // Need (components-1) cables to connect components together
    }

    private int findParent(int[] parent, int i)
    {
        if (i == parent[i])
        {
            return i;
        }
        return parent[i] = findParent(parent, parent[i]); // Path compression
    }
}