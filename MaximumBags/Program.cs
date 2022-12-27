var solution = new Solution();
var capacity = new int[] { 2, 3, 4, 5 };
var rocks = new int[] { 1, 2, 4, 4 };
Console.WriteLine(solution.MaximumBags(capacity, rocks, 2));

// https://leetcode.com/problems/maximum-bags-with-full-capacity-of-rocks
public class Solution
{
    public int MaximumBags(int[] capacity, int[] rocks, int additionalRocks)
    {
        var n = capacity.Length;
        var diff = new int[n];
        for (int i = 0; i < n; i++)
        {
            diff[i] = capacity[i] - rocks[i];
        }
        Array.Sort(diff);
        int result = default;
        foreach (var item in diff)
        {
            if (additionalRocks >= item)
            {
                additionalRocks = additionalRocks - item;
                result++;
            }
        }
        return result;
    }
}