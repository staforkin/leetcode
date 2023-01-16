using System.Collections.Generic;

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
        // 0123456789
        // ----------
        // -[-]------
        // ------[--]

        // --[--]----

        var result = new LinkedList<int[]>();
        int i = 0;
        // add all the intervals ending before newInterval starts
        while (i < intervals.Length && intervals[i][1] < newInterval[0])
        {
            result.AddLast(intervals[i]);
            i++;
        }

        // merge all overlapping intervals to one considering newInterval
        while (i < intervals.Length && intervals[i][0] <= newInterval[1])
        {
            // we could mutate newInterval here also
            newInterval[0] = Math.Min(newInterval[0], intervals[i][0]);
            newInterval[1] = Math.Max(newInterval[1], intervals[i][1]);
            i++;
        }

        // add the union of intervals we got
        result.AddLast(newInterval);

        // add all the rest
        while (i < intervals.Length)
        {
            result.AddLast(intervals[i]);
            i++;
        }

        return result.ToArray();
    }
}