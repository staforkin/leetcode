var solution = new Solution();
var accounts = new int[][] { new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 } };
Console.WriteLine(solution.MaximumWealth(accounts));

// https://leetcode.com/problems/richest-customer-wealth
public class Solution
{
    public int MaximumWealth(int[][] accounts)
    {
        var max = 0;
        for (int i = 0; i < accounts.Length; i++)
        {
            var t = accounts[i].Sum();
            if (t > max)
            {
                max = t;
            }
        }

        return max;
    }
}