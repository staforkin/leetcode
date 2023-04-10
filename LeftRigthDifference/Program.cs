var solution = new Solution();
Console.WriteLine(string.Join(",", solution.LeftRigthDifference(new[] { 10, 4, 8, 3 })));

// https://leetcode.com/problems/left-and-right-sum-differences
public class Solution
{
    public int[] LeftRigthDifference(int[] nums)
    {
        int n = nums.Length;
        int[] ans = new int[n];
        int[] a = new int[n + 1];
        a[0] = 0;
        for (int i = 0; i < n; i++)
        {
            a[i + 1] = a[i] + nums[i];
        }

        for (int i = 1; i < n + 1; i++)
        {
            ans[i - 1] = Math.Abs(a[n] - a[i] - a[i - 1]);
        }
        return ans;
    }
}