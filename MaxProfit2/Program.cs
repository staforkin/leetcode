var solution = new Solution();
Console.WriteLine(solution.MaxProfit(new []{2,4,1}));

//https://leetcode.com/problems/best-time-to-buy-and-sell-stock
public class Solution
{
    public int MaxProfit(int[] prices)
    {
        // 2 4 1
        int maxCur = 0, maxSoFar = 0;
        for(int i = 1; i < prices.Length; i++) {
            maxCur = Math.Max(0, maxCur += prices[i] - prices[i-1]);
            maxSoFar = Math.Max(maxCur, maxSoFar);
        }
        return maxSoFar;
    }
}