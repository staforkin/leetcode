var solution = new Solution();
var grid = new int[][]{
    new int[]{0,0,0,0},
    new int[]{1,0,1,0},
    new int[]{0,1,1,0},
    new int[]{0,0,0,0}
};
Console.WriteLine(solution.NumEnclaves(grid));

// https://leetcode.com/problems/number-of-enclaves
public class Solution
{
    public int NumEnclaves(int[][] grid)
    {
        int result = 0;
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (i == 0 || j == 0 || i == grid.Length - 1 || j == grid[i].Length - 1)
                    dfs(grid, i, j);
            }
        }

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == 1)
                    result++;
            }
        }

        return result;
    }

    public void dfs(int[][] grid, int i, int j)
    {
        if (i >= 0
            && i <= grid.Length - 1
            && j >= 0
            && j <= grid[i].Length - 1 && grid[i][j] == 1)
        {
            grid[i][j] = 0;
            dfs(grid, i + 1, j);
            dfs(grid, i - 1, j);
            dfs(grid, i, j + 1);
            dfs(grid, i, j - 1);
        }
    }
}