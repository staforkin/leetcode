var solution = new Solution();
Console.WriteLine(solution.FindLHS(new[] { 1, 3, 2, 2, 5, 2, 3, 7 }));

// https://leetcode.com/problems/longest-harmonious-subsequence/
public class Solution
{
    public int FindLHS(int[] nums)
    {
        var map = new Dictionary<long, int>();
        foreach (long num in nums)
        {
            if (map.ContainsKey(num))
            {
                map[num]++;
            }
            else
            {
                map.Add(num, 1);
            }
        }
        int result = 0;
        foreach (long key in map.Keys)
        {
            if (map.ContainsKey(key + 1))
            {
                result = Math.Max(result, map[key + 1] + map[key]);
            }
        }
        return result;
    }
}