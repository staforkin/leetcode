var solution = new Solution();
Console.WriteLine(string.Join(",", solution.FrequencySort(new[] { 2,3,1,3,2 })));

// https://leetcode.com/problems/sort-array-by-increasing-frequency
public class Solution
{
    public int[] FrequencySort(int[] nums)
    {
        var map = nums.GroupBy(i => i).ToDictionary(i=>i.Key, j=>j.Count());
        Array.Sort(nums, Comparer<int>.Create((a,b)=> map[a]!=map[b]?map[a]-map[b] : b-a));
        return nums;
    }
}