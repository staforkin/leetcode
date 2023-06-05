var solution = new Solution();
var coordinates = new int[][]{
    new int[] { 1, 2 },
    new int[] { 2, 3 },
    new int[] { 3, 4 },
    new int[] { 4, 5 },
    new int[] { 5, 6 },
    new int[] { 6, 7 }
    };
Console.WriteLine(solution.CheckStraightLine(coordinates));

// https://leetcode.com/problems/check-if-it-is-a-straight-line
public class Solution
{
    public bool CheckStraightLine(int[][] coordinates)
    {
        int x0 = coordinates[0][0], y0 = coordinates[0][1],
            x1 = coordinates[1][0], y1 = coordinates[1][1];
        int dx = x1 - x0, dy = y1 - y0;
        foreach (int[] co in coordinates)
        {
            int x = co[0], y = co[1];
            if (dx * (y - y1) != dy * (x - x1))
            {
                return false;
            }
        }
        return true;
    }
}