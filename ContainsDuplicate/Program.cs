var solution = new Solution();
Console.WriteLine(solution.ContainsDuplicate(new[] { 1, 2, 3, 1 }));

//https://leetcode.com/problems/contains-duplicate/
public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        return nums.ToHashSet().Count < nums.Length;
    }
}