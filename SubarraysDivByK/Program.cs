var solution = new Solution();
Console.WriteLine(solution.SubarraysDivByK(new[] { 4, 5, 0, -2, -3, 1 }, 5));

// https://leetcode.com/problems/subarray-sums-divisible-by-k
public class Solution
{
    public int SubarraysDivByK(int[] nums, int k)
    {
        int[] count = new int[k];
        count[0] = 1;
        int prefix = 0, res = 0;
        foreach (int a in nums)
        {
            prefix = (prefix + a % k + k) % k;
            Console.WriteLine(prefix);
            res += count[prefix]++;
        }
        return res;
    }
}