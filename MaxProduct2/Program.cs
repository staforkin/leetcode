var solution = new Solution();
Console.WriteLine(solution.MaxProduct(new[] { 2, 3, -2, 4, 2 }));

// https://leetcode.com/problems/maximum-product-subarray/
public class Solution
{
    public int MaxProduct(int[] nums)
    {
        //      2 3  -2  4   2   2

        //2     - 6 -12 -48 -96 -192
        //3     - - -6  -24 -48  -96
        //-2    - - -   -8  -16  -32
        //4     - -  -  -   8    16
        int n = nums.Length;
        int r = nums[0];

        for (int i = 1, imax = r, imin = r; i < n; i++)
        {
            if (nums[i] < 0)
            {
                Swap(ref imax, ref imin);
            }

            imax = Math.Max(nums[i], imax * nums[i]);
            imin = Math.Min(nums[i], imin * nums[i]);
            r = Math.Max(r, imax);
        }
        return r;
    }

    private void Swap(ref int a, ref int b)
    {
        int t = a;
        a = b;
        b = t;
    }
}