var solution = new Solution();
Console.WriteLine(solution.FindMaxConsecutiveOnes(new int[] { 1, 1, 0, 1, 1, 1 }));

// https://leetcode.com/problems/max-consecutive-ones
public class Solution
{
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        var res = 0;
        var max = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 1)
            {
                res++;
            }
            else
            {
                max = Math.Max(res, max);
                res = 0;
            }
        }
        max = Math.Max(res, max);
        return max;
    }
}