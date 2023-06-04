var solution = new Solution();
var isConnected = new int[][] { new int[] { 1, 1, 0 }, new int[] { 1, 1, 0 }, new int[] { 0, 0, 1 } };
Console.WriteLine(solution.FindCircleNum(isConnected));

// https://leetcode.com/problems/number-of-provinces
public class Solution
{
    public int FindCircleNum(int[][] isConnected)
    {
        //110
        //110
        //001
        int[] visited = new int[isConnected.Length];
        int count = 0;
        for (int i = 0; i < isConnected.Length; i++)
        {
            if (visited[i] == 0)
            {
                dfs(isConnected, visited, i);
                count++;
            }
        }
        return count;
    }

    private void dfs(int[][] isConnected, int[] visited, int i)
    {
        for (int j = 0; j < isConnected.Length; j++)
        {
            if (isConnected[i][j] == 1 && visited[j] == 0)
            {
                visited[j] = 1;
                dfs(isConnected, visited, j);
            }
        }
    }
}