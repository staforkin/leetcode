﻿var solution = new Solution();
Console.WriteLine(solution.MaxProfit(new[]{7,1,5,3,6,4}));

public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int result = 0;
        bool hitEnd = false;
        for (int i = 0; i < prices.Length - 1; i++)
        {
            int delta = 0;
            for (int j = i + 1; j < prices.Length; j++)
            {
                int t = prices[j] - prices[i];
                if (t > delta)
                {
                    delta = t;
                }
                else
                {
                    i = j - 1;
                    break;
                }
                if (j == prices.Length - 1)
                {
                    hitEnd = true;
                }
            }
            result += delta;
            if (hitEnd)
            { break; }
        }
        return result;
    }
}