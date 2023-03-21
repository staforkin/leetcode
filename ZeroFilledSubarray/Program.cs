var solution = new Solution();
//Console.WriteLine(solution.ZeroFilledSubarray(new[] { 1, 3, 0, 0, 2, 0, 0, 4 }));
//Console.WriteLine(solution.ZeroFilledSubarray(new[] { 0, 0, 0, 2, 0, 0 }));
Console.WriteLine(solution.ZeroFilledSubarray(new[] { 0, 0, 0, 0, 0 }));

// https://leetcode.com/problems/number-of-zero-filled-subarrays
public class Solution
{
    public long ZeroFilledSubarray(int[] nums)
    {
        long res = 0;
        int count = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                count = 0;
            }
            else
            {
                count += 1;
                res += count;
            }
        }
        return res;
    }
}