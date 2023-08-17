var solution = new Solution();
Console.WriteLine(solution.MaximumProduct(new[] { 1, 2, 3 }));

// https://leetcode.com/problems/maximum-product-of-three-numbers
public class Solution
{
    public int MaximumProduct(int[] nums)
    {
        int max1 = int.MinValue;
        int max2 = int.MinValue;
        int max3 = int.MinValue;
        int min1 = int.MaxValue;
        int min2 = int.MaxValue;
        foreach (int n in nums)
        {
            if (n > max1)
            {
                max3 = max2;
                max2 = max1;
                max1 = n;
            }
            else if (n > max2)
            {
                max3 = max2;
                max2 = n;
            }
            else if (n > max3)
            {
                max3 = n;
            }

            if (n < min1)
            {
                min2 = min1;
                min1 = n;
            }
            else if (n < min2)
            {
                min2 = n;
            }
        }
        return Math.Max(max1 * max2 * max3, max1 * min1 * min2);
    }
}