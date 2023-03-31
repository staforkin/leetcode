var solution = new Solution();
Console.WriteLine(solution.Ways(new[] { "A..", "AAA", "..." }, 3));
//a..
//aaa
//...


// https://leetcode.com/problems/number-of-ways-of-cutting-a-pizza
public class Solution
{
    public int Ways(string[] pizza, int k)
    {
        int m = pizza.Length, n = pizza[0].Length;
        var dp = new int?[k, m, n];
        var preSum = new int[m + 1, n + 1]; // preSum[r][c] is the total number of apples in pizza[r:][c:]
        for (int r = m - 1; r >= 0; r--)
        {
            for (int c = n - 1; c >= 0; c--)
            {
                preSum[r, c] = preSum[r, c + 1] + preSum[r + 1, c] - preSum[r + 1, c + 1] + (pizza[r][c] == 'A' ? 1 : 0);
            }
        }
        return dfs(m, n, k - 1, 0, 0, dp, preSum);
    }
    int dfs(int m, int n, int k, int r, int c, int?[,,] dp, int[,] preSum)
    {
        if (preSum[r, c] == 0)
        {
            return 0; // if the remain piece has no apple -> invalid
        }
        if (k == 0)
        {
            return 1; // found valid way after using k-1 cuts
        }
        if (dp[k, r, c] != null)
        {
            return dp[k, r, c].Value;
        }
        int ans = 0;
        // cut in horizontal
        for (int nr = r + 1; nr < m; nr++)
        {
            if (preSum[r, c] - preSum[nr, c] > 0) // cut if the upper piece contains at least one apple
            {
                ans = (ans + dfs(m, n, k - 1, nr, c, dp, preSum)) % 1_000_000_007;
            }
        }
        // cut in vertical
        for (int nc = c + 1; nc < n; nc++)
        {
            if (preSum[r, c] - preSum[r, nc] > 0) // cut if the left piece contains at least one apple
            {
                ans = (ans + dfs(m, n, k - 1, r, nc, dp, preSum)) % 1_000_000_007;
            }
        }
        return (int)(dp[k, r, c] = ans);
    }
}