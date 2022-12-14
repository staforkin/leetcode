var solution = new Solution();
var arr = new[] { 1, 9, 1, 9, 1, 1, 9, 1, 9 };
Console.WriteLine(solution.Rob(arr));

// https://leetcode.com/problems/house-robber/
public class Solution
{
    public int Rob(int[] nums)
    {
        // 1 9 1 9 1 1 9 1 9
        // 
        if (nums.Length == 0) return 0;
        int prev1 = 0;
        int prev2 = 0;
        foreach (int num in nums)
        {
            int tmp = prev1;
            prev1 = Math.Max(prev2 + num, prev1);
            prev2 = tmp;
        }
        return prev1;
    }
}