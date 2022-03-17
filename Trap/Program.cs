var solution = new Solution();
Console.WriteLine(solution.Trap(new[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 }) + " expected 6");
Console.WriteLine(solution.Trap(new[] { 4, 2, 0, 3, 2, 5 }) + " expected 9");

//https://leetcode.com/problems/trapping-rain-water/
public class Solution
{
    public int Trap(int[] height)
    {
        if (height.Length==0)
            return 0;
        int res = 0;
        int n = height.Length;
        var leftMax = new int[n];
        var rightMax = new int[n];
        leftMax[0] = height[0];
        for (int i = 1; i < n; i++)
        {
            leftMax[i] = Math.Max(height[i], leftMax[i - 1]);
        }
        rightMax[n - 1] = height[n - 1];
        for (int i = n - 2; i >= 0; i--)
        {
            rightMax[i] = Math.Max(height[i], rightMax[i + 1]);
        }
        for (int i = 1; i < n - 1; i++)
        {
            res += Math.Min(leftMax[i], rightMax[i]) - height[i];
        }
        return res;
    }
}