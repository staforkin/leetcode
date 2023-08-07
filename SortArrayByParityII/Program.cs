var solution = new Solution();
Console.WriteLine(string.Join(",", solution.SortArrayByParityII(new[] { 4, 2, 5, 7 })));

// https://leetcode.com/problems/sort-array-by-parity-ii
public class Solution
{
    public int[] SortArrayByParityII(int[] nums)
    {
        var res = new int[nums.Length];
        int oddIndex = 0;
        int evenIndex = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 2 == 0)
            {
                res[oddIndex] = nums[i];
                oddIndex += 2;
            }
            else
            {
                res[evenIndex] = nums[i];
                evenIndex += 2;
            }
        }
        return res;
    }
}