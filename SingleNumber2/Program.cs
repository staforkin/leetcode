var solution = new Solution();
Console.WriteLine(solution.SingleNumber(new[] { 0, 1, 0, 1, 0, 1, 99 }));

// https://leetcode.com/problems/single-number-ii
public class Solution
{
    public int SingleNumber(int[] nums)
    {
        //2 3 4 2 2 4 4
        int ans = 0;

        for (int i = 0; i < 32; ++i)
        {
            int sum = 0;
            foreach (int num in nums)
            {
                sum += num >> i & 1;
            }
            sum %= 3;
            ans |= sum << i;
        }

        return ans;
    }
}