var solution = new Solution();
Console.WriteLine(string.Join(",", solution.SortedSquares(new[] { -4, -1, 0, 3, 10 })));

// https://leetcode.com/problems/squares-of-a-sorted-array
public class Solution
{
    public int[] SortedSquares(int[] nums)
    {

        // -4 -1 0 3 10
        int n = nums.Length;
        int[] result = new int[n];
        int i = 0, j = n - 1;
        for (int p = n - 1; p >= 0; p--)
        {
            if (Math.Abs(nums[i]) > Math.Abs(nums[j]))
            {
                result[p] = nums[i] * nums[i];
                i++;
            }
            else
            {
                result[p] = nums[j] * nums[j];
                j--;
            }
        }
        return result;
    }
}