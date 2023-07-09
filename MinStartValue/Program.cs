var solution = new Solution();
Console.WriteLine(solution.MinStartValue(new[] { -3, 2, -3, 4, 2 }));

// https://leetcode.com/problems/minimum-value-to-get-positive-step-by-step-sum
public class Solution
{
    public int MinStartValue(int[] nums)
    {
        int start = 1;
        int sum = start;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            //Console.WriteLine($"sum is {sum}");
            if (sum < 1)
            {
                start = start + (1 - sum);
                sum += (1 - sum);
                //Console.WriteLine($"  new start is {start}");
            }
        }
        return start;
    }
}