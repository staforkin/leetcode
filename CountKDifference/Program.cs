var solution = new Solution();
Console.WriteLine(solution.CountKDifference(new[] { 1, 2, 2, 1 }, 1));

// https://leetcode.com/problems/count-number-of-pairs-with-absolute-difference-k
public class Solution
{
    public int CountKDifference(int[] nums, int k)
    {
        int res = 0;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (Math.Abs(nums[i] - nums[j]) == k)
                {
                    res++;
                }
            }
        }
        return res;
    }
}