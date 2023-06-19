var solution = new Solution();
Console.WriteLine(solution.LargestAltitude(new[] { -4, -3, -2, -1, 4, 3, 2 }));

// https://leetcode.com/problems/find-the-highest-altitude
public class Solution
{
    public int LargestAltitude(int[] gain)
    {
        for (int i = 1; i < gain.Length; i++)
        {
            gain[i] = gain[i] + gain[i - 1];
        }
        return Math.Max(0, gain.Max());
    }
}