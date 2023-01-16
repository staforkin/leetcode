var solution = new Solution();
var intervals = new int[][] { new int[] { 1, 3 }, new int[] { 6, 9 } };
foreach (var item in solution.Insert(intervals, new int[] { 2, 5 }))
{
    Console.WriteLine(string.Join(",", item));
}

// https://leetcode.com/problems/insert-interval
public class Solution
{
    public int[][] Insert(int[][] intervals, int[] newInterval)
    {

    }
}