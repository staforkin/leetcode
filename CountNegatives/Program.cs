var solution = new Solution();
var grid = new int[][]{
    new []{4,3,2,-1},
    new []{3,2,1,-1},
    new []{1,1,-1,-2},
    new []{-1,-1,-2,-3}
};
Console.WriteLine(solution.CountNegatives(grid));

// https://leetcode.com/problems/count-negative-numbers-in-a-sorted-matrix
public class Solution
{
    public int CountNegatives(int[][] grid)
    {
        // 4  3  2 -1
        // 3  2  1 -1
        // 1  1 -1 -2
        //-1 -1 -2 -3

        int m = grid.Length;
        int n = grid[0].Length, r = m - 1, c = 0, cnt = 0;
        while (r >= 0 && c < n)
        {
            if (grid[r][c] < 0)
            {
                --r;
                cnt += n - c;
            }
            else
            {
                ++c;
            }
        }
        return cnt;
    }
}