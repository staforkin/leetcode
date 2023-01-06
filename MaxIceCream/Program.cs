var solution = new Solution();
Console.WriteLine(solution.MaxIceCream(new int[] { 1, 3, 2, 4, 1 }, 7));

// https://leetcode.com/problems/maximum-ice-cream-bars
public class Solution
{
    public int MaxIceCream(int[] costs, int coins)
    {
        // 1 3 2 4 1
        // 1 1 2 3 4
        // 1 2 4 7 11


        // 1 1 2  coins 3
        Array.Sort(costs);
        int res = default;
        for (int i = 0; i < costs.Length; i++)
        {
            if (costs[i] <= coins)
            {
                coins -= costs[i];
                res++;
            }
            else
            {
                break;
            }
        }
        return res;
    }
}