var solution = new Solution();
var grid = new int[][] { new int[] { 0, 0, 0 }, new int[] { 0, 1, 0 }, new int[] { 0, 0, 0 } };
var grid2 = new int[][] { new int[] { 0, 0, 0 },new int[] { 0, 0, 0 } };
Console.WriteLine(solution.UniquePathsWithObstacles(grid));
Console.WriteLine(solution.UniquePathsWithObstacles(grid2));
// https://leetcode.com/problems/unique-paths-ii/
public class Solution
{
    public int UniquePathsWithObstacles(int[][] obstacleGrid)
    {
        var width = obstacleGrid[0].Length;
        var dp = new int[width];
        dp[0] = 1;
        foreach (int[] row in obstacleGrid)
        {
            for (int j = 0; j < width; j++)
            {
                if (row[j] == 1)
                {
                    dp[j] = 0;
                }
                else if (j > 0)
                {
                    dp[j] += dp[j - 1];
                }
            }
        }
        return dp[width - 1];
    }
}