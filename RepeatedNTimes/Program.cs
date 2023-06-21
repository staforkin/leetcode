var solution = new Solution();
Console.WriteLine(solution.RepeatedNTimes(new[] { 1, 2, 3, 3 }));

// https://leetcode.com/problems/n-repeated-element-in-size-2n-array
public class Solution
{
    public int RepeatedNTimes(int[] nums)
    {
        var dict = new Dictionary<int, int>();
        var n = nums.Length / 2;
        for (int i = 0; i < nums.Length; i++)
        {
            if (dict.ContainsKey(nums[i]))
            {
                dict[nums[i]]++;
            }
            else
            {
                dict.Add(nums[i], 1);
            }
            if (dict[nums[i]] == n)
            {
                return nums[i];
            }
        }
        return 0;
    }
}