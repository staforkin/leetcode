var solution = new Solution();
Console.WriteLine(solution.MinimumAverageDifference(new[] { 2,5,3,9,5,3 }));

// https://leetcode.com/problems/minimum-average-difference
public class Solution
{
    public int MinimumAverageDifference(int[] nums)
    {
        long sumEnd = 0, sumFront = 0;
        int res = 0, diff = int.MaxValue, n = nums.Length;
        foreach (var item in nums)
        {
            sumEnd += item;
        }

        for (int i = 0; i < n; i++)
        {
            sumFront += nums[i];
            sumEnd -= nums[i];

            long avg1 = sumFront / (i + 1);
            long avg2 = (i == n - 1) ? 0 : sumEnd / (n - i - 1);

            if (Math.Abs(avg1 - avg2) < diff)
            {
                diff = (int)Math.Abs(avg1 - avg2);
                res = i;
            }
        }

        return res;
    }
}