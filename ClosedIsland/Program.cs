var solution = new Solution();
var grid = new int[][]{
    new int[]{1,1,1,1,1,1,1,0},
    new int[]{1,0,0,0,0,1,1,0},
    new int[]{1,0,1,0,1,1,1,0},
    new int[]{1,0,0,0,0,1,0,1},
    new int[]{1,1,1,1,1,1,1,0},
};
Console.WriteLine(solution.ClosedIsland(grid));

// https://leetcode.com/problems/number-of-closed-islands
public class Solution
{
    int[][] dir = new int[][] { new int[] { 1, 0 }, new int[] { -1, 0 }, new int[] { 0, 1 }, new int[] { 0, -1 } };
    public int ClosedIsland(int[][] grid)
    {
        int res = 0;
        for (int i = 1; i < grid.Length - 1; i++)
        {
            for (int j = 1; j < grid[0].Length - 1; j++)
            {
                if (grid[i][j] == 0)
                {
                    if (dfs(grid, i, j))
                    {
                        res++;
                    }
                }
            }
        }

        return res;
    }

    public bool dfs(int[][] grid, int i, int j)
    {
        if (i == 0 || i == grid.Length - 1 || j == 0 || j == grid[0].Length - 1)
        {
            return false;
        }

        if (grid[i][j] == 1 || grid[i][j] == 2)
        {
            return true;
        }

        grid[i][j] = 2;
        bool res = true;

        foreach (int[] d in dir)
        {
            int m = i + d[0];
            int n = j + d[1];
            if (grid[m][n] == 0)
            {
                res = dfs(grid, m, n) && res;
            }
        }

        return res;
    }
}