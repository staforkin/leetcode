var solution = new Solution();
Console.WriteLine(solution.FirstMissingPositive(new[] { 7, 8, 9, 11, 12 }) + " expected 1");
Console.WriteLine(solution.FirstMissingPositive(new[] { 7, 8, 9, 11, 12, 1 }) + " expected 2");
Console.WriteLine(solution.FirstMissingPositive(new[] { 3, 4, -1, 1 }) + " expected 2");
Console.WriteLine(solution.FirstMissingPositive(new[] { 1, 2, 0 }) + " expected 3");
Console.WriteLine(solution.FirstMissingPositive(new[] { 2, 3, 0, 1 }) + " expected 4");
Console.WriteLine(solution.FirstMissingPositive(new[] { 1, 4, 5, 6, 2 }) + " expected 3");
Console.WriteLine(solution.FirstMissingPositive(new[] { 1, 3, 2, 5, 4 }) + " expected 6");

//https://leetcode.com/problems/first-missing-positive/
public class Solution
{
    public int FirstMissingPositive(int[] nums)
    {
        int n = nums.Length;
        for (int i = 0; i < n; i++)
        {
            if (nums[i] <= 0 || nums[i] > n)
            {
                nums[i] = n + 1;
            }
        }
        for (int i = 0; i < n; i++)
        {
            int num = Math.Abs(nums[i]);
            if (num > n)
            {
                continue;
            }
            num--;
            if (nums[num] > 0)
            {
                nums[num] = -1 * nums[num];
            }
        }
        for (int i = 0; i < n; i++)
        {
            if (nums[i] >= 0)
            {
                return i + 1;
            }
        }
        return n + 1;
    }
}