var solution = new Solution();
Console.WriteLine(solution.NumTilings(30));

// https://leetcode.com/problems/domino-and-tromino-tiling/
public class Solution
{
    public int NumTilings(int n)
    {
        // 1 2  1 1
        // 1 2  2 2

        // 1 1 2    1 2 2
        // 1 2 2    1 1 2

        int md = 1_000_000_000;
        md += 7;
        var dp = new long[1001];
        dp[1] = 1;
        dp[2] = 2;
        dp[3] = 5;
        if (n <= 3)
        {
            return (int)dp[n];
        }
        for (int i = 4; i <= n; ++i)
        {
            dp[i] = 2 * dp[i - 1] + dp[i - 3];
            dp[i] %= md;
        }
        return (int)dp[n];
    }
}