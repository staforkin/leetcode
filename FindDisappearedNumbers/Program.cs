var solution = new Solution();
Console.WriteLine(string.Join(",", solution.FindDisappearedNumbers(new[] { 4, 3, 2, 7, 8, 2, 3, 1 })));

// https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array
public class Solution
{
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        // 4, 3, 2, 7, 8, 2, 3, 1
        var list = new List<int>();
        int idx = -1;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] < 0)
            {
                idx = nums[i] * -1 - 1;
            }
            else
            {
                idx = nums[i] - 1;
            }

            if (nums[idx] > 0)
            {
                nums[idx] = -nums[idx];
            }

        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0)
            {
                list.Add(i + 1);
            }
        }
        
        return list;
    }
}