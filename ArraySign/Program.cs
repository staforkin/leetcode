var solution = new Solution();
Console.WriteLine(solution.ArraySign(new[] { 56, 32, 76, 92, 78, 91, -100, -82, -40, -63, -48, -55, -59, -81, -35, -59, -29 }));

// https://leetcode.com/problems/sign-of-the-product-of-an-array
public class Solution
{
    public int ArraySign(int[] nums)
    {
        var res = 1;
        var hs = nums.ToHashSet();
        if (hs.Contains(0))
        {
            return 0;
        }
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0)
            {
                res = res * 1;
            }
            else
            {
                res = res * (-1);
            }
        }
        return res;
    }
}