var solution = new Solution();
Console.WriteLine(solution.DistributeCookies(new[] { 8, 15, 10, 20, 8 }, 2));

// https://leetcode.com/problems/fair-distribution-of-cookies
public class Solution
{
    int ans = int.MaxValue;
    public int DistributeCookies(int[] cookies, int k)
    {
        // 8 15 8 = 31
        // 10 20 = 30
        // 31 - 30 = 1

        helper(cookies, 0, k, new int[k]);
        return ans;
    }

    void helper(int[] cookies, int start, int k, int[] temp)
    {
        if (start == cookies.Length)
        {
            int max = 0;
            foreach (int c in temp)
            {
                max = Math.Max(max, c);
            }
            ans = Math.Min(ans, max);
            return;
        }
        for (int i = 0; i < k; i++)
        {
            temp[i] += cookies[start];
            helper(cookies, start + 1, k, temp);
            temp[i] -= cookies[start];
        }
    }
}