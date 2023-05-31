var solution = new Solution();
Console.WriteLine(solution.SumOddLengthSubarrays(new[] { 1, 4, 2, 5, 3 }));

// https://leetcode.com/problems/sum-of-all-odd-length-subarrays
public class Solution
{
    public int SumOddLengthSubarrays(int[] arr)
    {
        // 1 4 2 5 3
        // 1 5 7 12 15

        // 1 + 4 + 2 + 5 + 3
        //+ 7 + (12-1) + (15-5)
        // + 15
        var n = arr.Length;
        var ps = new int[n];
        ps[0] = arr[0];
        for (int i = 1; i < n; i++)
        {
            ps[i] = ps[i - 1] + arr[i];
        }
        int res = default;
        res += ps[n - 1];
        int m = default;
        for (int odd = 3; odd <= n; odd += 2)
        {
            for (int i = odd - 1; i < n; i++)
            {
                if (i - odd < 0)
                {
                    res += ps[i];
                }
                else
                {
                    res += (ps[i] - ps[i - odd]);
                }
            }
        }
        return res;
    }
}