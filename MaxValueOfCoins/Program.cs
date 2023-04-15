var solution = new Solution();
Console.WriteLine(solution.MaxValueOfCoins(new List<IList<int>>() { new[] { 1, 100, 3 }, new[] { 7, 8, 9 } }, 2));

// https://leetcode.com/problems/maximum-value-of-k-coins-from-piles
public class Solution
{
    public int MaxValueOfCoins(IList<IList<int>> piles, int k)
    {
        var memo = new int?[piles.Count() + 1][];
        for (int i = 0; i < memo.Length; i++)
        {
            memo[i] = new int?[k + 1];
        }

        var r = Dp(piles, memo, 0, k);
        return r;
    }

    private int Dp(IList<IList<int>> piles, int?[][] memo, int i, int k)
    {
        if (k == 0 || i == piles.Count())
        {
            return 0;
        }
        if (memo[i][k] != null)
        {
            return memo[i][k].Value;
        }

        int res = Dp(piles, memo, i + 1, k);
        int cur = 0;

        for (int j = 0; j < Math.Min(piles[i].Count(), k); ++j)
        {
            cur += piles[i][j];
            res = Math.Max(res, cur + Dp(piles, memo, i + 1, k - j - 1));
        }
        return (int)(memo[i][k] = res);
    }
}