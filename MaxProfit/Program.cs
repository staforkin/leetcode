using System;

namespace max_profit
{
    class Program
    {
        static void Main(string[] args)
        {
            var prices = new[] { 1, 2, 3, 4, 5 };//4
            int result = MaxProfit(prices);
            Console.Write(result);
        }

        public static int MaxProfit(int[] prices)
        {
            int result = 0;
            bool hitEnd = false;
            for (int i = 0; i <  prices.Length-1; i++)
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
}
