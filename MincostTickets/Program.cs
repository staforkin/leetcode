var solution = new Solution();
Console.WriteLine(solution.MincostTickets(new[] { 1, 4, 6, 7, 8, 20 }, new[] { 2, 7, 15 }));

// https://leetcode.com/problems/minimum-cost-for-tickets
public class Solution
{
    public int MincostTickets(int[] days, int[] costs)
    {
        // 2 7 15

        // 1 4 6 7 8 20

        var dayIncluded = new bool[366];
        foreach (int day in days)
        {
            dayIncluded[day] = true;
        }
        int[] minCost = new int[366];
        minCost[0] = 0;
        for (int i = 1; i < 366; i++)
        {
            if (!dayIncluded[i])
            {
                minCost[i] = minCost[i - 1];
                continue;
            }
            int min;
            min = minCost[i - 1] + costs[0];
            min = Math.Min(min, minCost[Math.Max(0, i - 7)] + costs[1]);
            min = Math.Min(min, minCost[Math.Max(0, i - 30)] + costs[2]);
            minCost[i] = min;
        }
        return minCost[365];
    }
}