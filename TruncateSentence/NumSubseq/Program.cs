var solution = new Solution();
Console.WriteLine(solution.NumSubseq(new[] { 3, 5, 6, 7 }, 9));

// https://leetcode.com/problems/number-of-subsequences-that-satisfy-the-given-sum-condition
public class Solution
{
    public int NumSubseq(int[] nums, int target)
    {
        Array.Sort(nums);
        int res = 0, n = nums.Length, l = 0, r = n - 1, mod = (int)1e9 + 7;
        int[] pows = new int[n];
        pows[0] = 1;
        for (int i = 1; i < n; ++i)
        {
            pows[i] = pows[i - 1] * 2 % mod;
        }
        while (l <= r)
        {
            if (nums[l] + nums[r] > target)
            {
                r--;
            }
            else
            {
                res = (res + pows[r - l++]) % mod;
            }
        }
        return res;
    }
}