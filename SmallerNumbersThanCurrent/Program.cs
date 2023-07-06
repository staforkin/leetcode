var solution = new Solution();
Console.WriteLine(string.Join(",", solution.SmallerNumbersThanCurrent(new[] { 8, 1, 2, 2, 3 })));

// https://leetcode.com/problems/how-many-numbers-are-smaller-than-the-current-number
public class Solution
{
    public int[] SmallerNumbersThanCurrent(int[] nums)
    {
        // 8 1 2 2 3
        // 1 2 2 3 8
        int[] count = new int[101];
        int[] res = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            count[nums[i]]++;
        }

        for (int i = 1; i <= 100; i++)
        {
            count[i] += count[i - 1];
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
            {
                res[i] = 0;
            }
            else
            {
                res[i] = count[nums[i] - 1];
            }
        }

        return res;
    }
}