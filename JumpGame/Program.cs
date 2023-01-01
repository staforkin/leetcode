var solution = new Solution();
Console.WriteLine(solution.Jump(new[] { 2, 3, 1, 1, 4 }));

// https://leetcode.com/problems/jump-game-ii
public class Solution
{
    public int Jump(int[] nums)
    {
        int jumps = 0;
        int end = 0;
        int farthest = 0;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            farthest = Math.Max(farthest, i + nums[i]);
            Console.WriteLine($"farthest = {farthest}");
            if (i == end)
            {
                jumps++;
                Console.WriteLine($"jumps = {jumps}");
                end = farthest;
            }
        }
        return jumps;
    }
}