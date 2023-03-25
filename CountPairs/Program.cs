var solution = new Solution();
var edges = new int[][] {
    new int[] { 0, 1 },
    new int[] { 0, 2 },
    new int[] { 1, 2 } };
Console.WriteLine(solution.CountPairs(3, edges));

// https://leetcode.com/problems/count-unreachable-pairs-of-nodes-in-an-undirected-graph
public class Solution
{
    public long CountPairs(int n, int[][] edges)
    {
        //0:1,2
        //1:0,2
        //2:0,1
        var list = new List<List<int>>();
        for (int i = 0; i < n; i++)
        {
            list.Add(new List<int>());
        }
        foreach (var item in edges)
        {
            list[item[0]].Add(item[1]);
            list[item[1]].Add(item[0]);
        }

        bool[] visited = new bool[n];
        int numVisitedNodes = 0;
        long numUnreachablePairsOfNodes = 0;

        for (int node = 0; node < n; ++node)
        {
            if (!visited[node])
            {
                int numNodesInCurrentGroup = dfs(node, visited, list);
                numUnreachablePairsOfNodes += (long)numNodesInCurrentGroup * numVisitedNodes;
                numVisitedNodes += numNodesInCurrentGroup;
            }
        }
        return numUnreachablePairsOfNodes;
    }

    private int dfs(int node, bool[] visited, List<List<int>> list)
    {
        visited[node] = true;
        int numConnectedNodes = 1;

        foreach (int neighbor in list[node])
        {
            if (!visited[neighbor])
            {
                numConnectedNodes += dfs(neighbor, visited, list);
            }
        }
        return numConnectedNodes;
    }
}