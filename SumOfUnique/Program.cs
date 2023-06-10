var solution = new Solution();
Console.WriteLine(solution.SumOfUnique(new[] { 1, 2, 3, 2 }));

// https://leetcode.com/problems/sum-of-unique-elements/
public class Solution
{
    public int SumOfUnique(int[] nums)
    {
        var hs = nums.GroupBy(i => i);
        return hs.Where(i => i.Count() == 1).Sum(i => i.Key);
    }
}