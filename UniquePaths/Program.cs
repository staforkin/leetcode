var solution = new Solution();
Console.WriteLine(solution.UniquePaths(3, 2) + " expected 3");

//https://leetcode.com/problems/unique-paths
public class Solution
{
    public int UniquePaths(int m, int n)
    {
        int[,] grid = new int[n, m];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (i == 0) grid[0, j] = 1;
                if (j == 0) grid[i, j] = 1;
                if (i != 0 && j != 0)
                {
                    int up = grid[(i - 1), j];
                    int left = grid[i, (j - 1)];
                    grid[i, j] = up + left;
                }
            }
        }
        return grid[(n - 1), (m - 1)];
        //return BackTrack(m - 1, n - 1);
    }


    private int BackTrack(int m, int n)
    {
        if (m < 0 || n < 0)
        {
            return 0;
        }
        else if (m == 0 || n == 0)
        {
            return 1;
        }
        else
        {
            return BackTrack(m - 1, n) + BackTrack(m, n - 1);
        }
    }
}