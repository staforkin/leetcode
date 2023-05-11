var solution = new Solution();
Console.WriteLine(solution.MaxUncrossedLines(new[] { 1, 3, 7, 1, 7, 5 }, new[] { 1, 9, 2, 5, 1 }));

// https://leetcode.com/problems/uncrossed-lines/
public class Solution
{
    public int MaxUncrossedLines(int[] nums1, int[] nums2)
    {
        int m = nums1.Length, n = nums2.Length;
        var dp = new int[m + 1][];
        for (int i = 0; i < dp.Length; i++)
        {
            dp[i] = new int[n + 1];
        }

        for (int i = 1; i <= m; ++i)
        {
            for (int j = 1; j <= n; ++j)
            {
                if (nums1[i - 1] == nums2[j - 1])
                {
                    dp[i][j] = 1 + dp[i - 1][j - 1];
                }
                else
                {
                    dp[i][j] = Math.Max(dp[i][j - 1], dp[i - 1][j]);
                }
            }
        }
        return dp[m][n];
    }
}
