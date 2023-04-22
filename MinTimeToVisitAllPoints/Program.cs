var solution = new Solution();
var points = new int[][] { new int[] { 1, 1 }, new int[] { 3, 4 }, new int[] { -1, 0 } };
Console.WriteLine(solution.MinTimeToVisitAllPoints(points));

// https://leetcode.com/problems/minimum-time-visiting-all-points
public class Solution
{
    public int MinTimeToVisitAllPoints(int[][] points)
    {
        int ans = 0;
        for (int i = 1; i < points.Length; ++i)
        {
            int[] cur = points[i], prev = points[i - 1];
            ans += Math.Max(Math.Abs(cur[0] - prev[0]), Math.Abs(cur[1] - prev[1]));
        }
        return ans;
    }
}
