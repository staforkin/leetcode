var solution = new Solution();
var arr = new int[][] { new int[] { 1, 3, 1 }, new int[] { 1, 5, 1 }, new int[] { 4, 2, 1 } };
Console.WriteLine(solution.MinPathSum(arr));

// https://leetcode.com/problems/minimum-path-sum
public class Solution
{
    public int MinPathSumDp(int[][] grid)
    {
        int height = grid.Length;
        int width = grid[0].Length;
        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < width; col++)
            {
                if (row == 0 && col == 0)
                {
                    grid[row][col] = grid[row][col];
                }
                else if (row == 0 && col != 0)
                {
                    grid[row][col] = grid[row][col] + grid[row][col - 1];
                }
                else if (col == 0 && row != 0)
                {
                    grid[row][col] = grid[row][col] + grid[row - 1][col];
                }
                else
                {
                    grid[row][col] = grid[row][col] + Math.Min(grid[row - 1][col], grid[row][col - 1]);
                }
            }
        }
        return grid[height - 1][width - 1];
    }

    public int MinPathSum(int[][] grid)
    {
        //  1   3   1
        //  1   5   1
        //  4   2   1
        int rows = grid.Length;
        int columns = grid[0].Length;
        return CalcMinPathFromPoint(rows - 1, columns - 1, grid);
    }

    private int CalcMinPathFromPoint(int row, int col, int[][] grid)
    {
        if (row == 0 && col == 0)
        {
            return grid[row][col];
        }

        if (row == 0)
        {
            return grid[row][col] + CalcMinPathFromPoint(row, col - 1, grid);
        }

        if (col == 0)
        {
            return grid[row][col] + CalcMinPathFromPoint(row - 1, col, grid);
        }

        return grid[row][col] + Math.Min(CalcMinPathFromPoint(row - 1, col, grid), CalcMinPathFromPoint(row, col - 1, grid));
    }

}