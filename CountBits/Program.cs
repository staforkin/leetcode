var solution = new Solution();
Console.WriteLine(string.Join(",", solution.CountBits(2)));

// https://leetcode.com/problems/counting-bits/
public class Solution
{
    public int[] CountBits(int n)
    {
        // 0: 0
        // 1: 1
        // 2: 1 0
        // 3: 1 1
        // 4: 1 0 0
        // 5: 1 0 1
        var res = new int[n+1];
        for (int i = 0; i <= n; i++)
        {
            res[i] = res[i >> 1] + (i & 1);
        }
        return res;
    }
}