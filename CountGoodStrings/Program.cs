var solution = new Solution();
Console.WriteLine(solution.CountGoodStrings(3, 3, 1, 1));

// https://leetcode.com/problems/count-ways-to-build-good-strings
public class Solution
{
    public int CountGoodStrings(int low, int high, int zero, int one)
    {
        var dp = new int[high + 1];
        int res = 0, mod = 1000000007;
        dp[0] = 1;
        for (int i = 1; i <= high; ++i)
        {
            // if we can add 0 string then add 
            if (i >= zero)
            {
                dp[i] = (dp[i] + dp[i - zero]) % mod;
            }
            // if we can add 1's string i.e i >= len of 1's string
            if (i >= one)
            {
                dp[i] = (dp[i] + dp[i - one]) % mod;
            }
            // if i is in between low and high add 
            if (i >= low)
            {
                res = (res + dp[i]) % mod;
            }
        }
        return res;
    }
}