var solution = new Solution();
Console.WriteLine(string.Join(",", solution.FinalPrices(new[] { 8, 4, 6, 2, 3 })));

// https://leetcode.com/problems/final-prices-with-a-special-discount-in-a-shop
public class Solution
{
    public int[] FinalPrices(int[] prices)
    {
        Stack<int> stack = new Stack<int>();
        for (int i = 0; i < prices.Length; i++)
        {
            while (stack.Any() && prices[stack.Peek()] >= prices[i])
            {
                prices[stack.Pop()] -= prices[i];
            }
            stack.Push(i);
        }
        return prices;
    }
}