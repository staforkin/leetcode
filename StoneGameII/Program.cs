var solution = new Solution();
Console.WriteLine(solution.StoneGameII(new[] { 2, 7, 9, 4, 4 }));

// https://leetcode.com/problems/stone-game-ii/
public class Solution
{
    public int StoneGameII(int[] piles)
    {

        int[] presum = new int[piles.Length];
        Array.Copy(piles, presum, piles.Length);
        for (int i = presum.Length - 2; i >= 0; i--)
        {
            presum[i] += presum[i + 1];
        }
        var memo = new int[piles.Length][];
        for (int i = 0; i < memo.Length; i++)
        {
            memo[i] = new int[piles.Length];
        }
        return dfs(presum, 1, 0, memo);
        
    }
    private int dfs(int[] presum, int m, int p, int[][] memo) {
        if (p + 2 * m >= presum.Length) { // last player takes all
            return presum[p];
        }

        if (memo[p][m] > 0)
        {
            return memo[p][m];
        }
        int res = 0, take = 0;
        for (int i = 1; i <= 2 * m; i++) {
            // current take
            take = presum[p] - presum[p + i];
            // take max of current + what lefts from other player max take
            res = Math.Max(res, take + presum[p + i] - dfs(presum, Math.Max(i, m), p + i, memo));
        }
        memo[p][m] = res;
        return res;
    }
}