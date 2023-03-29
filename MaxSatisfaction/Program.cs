var solution = new Solution();
Console.WriteLine(solution.MaxSatisfaction(new[] { -1, -8, 0, 5, -9 }));

// https://leetcode.com/problems/reducing-dishes
public class Solution
{
    public int MaxSatisfaction(int[] satisfaction)
    {
        Array.Sort(satisfaction);
        int res = 0, total = 0, n = satisfaction.Length;
        for (int i = n - 1; i >= 0 && satisfaction[i] + total > 0; --i)
        {
            total += satisfaction[i];
            res += total;
        }
        return res;
    }
}