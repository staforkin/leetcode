var solution = new Solution();
Console.WriteLine(solution.MaxProfit(new[] { 1, 2, 3, 0, 2 }));

// https://leetcode.com/problems/best-time-to-buy-and-sell-stock-with-cooldown
public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int sold = 0, hold = int.MinValue, rest = 0;
        for (int i = 0; i < prices.Length; ++i)
        {
            int prvSold = sold;
            sold = hold + prices[i];
            hold = Math.Max(hold, rest - prices[i]);
            rest = Math.Max(rest, prvSold);
        }
        return Math.Max(sold, rest);
    }
}