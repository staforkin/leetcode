var solution = new Solution();
Console.WriteLine(solution.CanJump(new[] { 2, 3, 1, 1, 4 }) + " expected True");
Console.WriteLine(solution.CanJump(new[] { 3, 2, 1, 0, 4 }) + " expected False");
Console.WriteLine(solution.CanJump(new[] { 0, 1 }) + " expected False");

//https://leetcode.com/problems/jump-game
public class Solution
{
    public bool CanJump(int[] nums)
    {
        int n = nums.Length;
        int last = n - 1;
        for (int i = n - 2; i >= 0; i--)
        {
            if (i + nums[i] >= last)
            {
                last = i;
            }
        }

        return last == 0;
    }
}