var solution = new Solution();
Console.WriteLine(solution.RemoveElement(new[] { 4, 4, 0, 1, 0, 2 }, 2));

// https://leetcode.com/problems/remove-element
public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        int begin = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[begin] = nums[i];
                begin++;
            }
        }
        return begin;
    }
}