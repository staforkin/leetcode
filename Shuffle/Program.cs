var solution = new Solution();
Console.WriteLine(string.Join(',', solution.Shuffle(new int[] { 2, 5, 1, 3, 4, 7 }, 3)));

// https://leetcode.com/problems/shuffle-the-array
public class Solution
{
    public int[] Shuffle(int[] nums, int n)
    {
        // |     |
        // 0 1 2 3 4 5
        // 2     3
        //   5     4
        //     1     7

        //[0 2 4]
        // 2 5 1
        // 3 4 7
        var res = new int[nums.Length];
        for (int i = 0; i < n; i++)
        {
            res[2 * i] = nums[i];
            res[2 * i + 1] = nums[n + i];
        }
        return res;
    }
}