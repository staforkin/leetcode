var solution = new Solution();
foreach (var item in solution.Merge(
    new[]{
        new []{1,3},
        new []{2,6},
        new []{8,10},
        new []{15,18},
    }
))
{
    Console.WriteLine(string.Join(",", item));
}

foreach (var item in solution.Merge(
    new[]{
        new []{1,4},
        new []{4,5}
    }
))
{
    Console.WriteLine(string.Join(",", item));
}

foreach (var item in solution.Merge(
    new[]{
        new []{1,4},
        new []{0,4}
    }
))
{
    Console.WriteLine(string.Join(",", item));
}

foreach (var item in solution.Merge(
    new[]{
        new []{1,4},
        new []{0,1}
    }
))
{
    Console.WriteLine(string.Join(",", item));
}

foreach (var item in solution.Merge(
    new[]{
        new []{1,4},
        new []{2,3}
    }
))
{
    Console.WriteLine(string.Join(",", item));
}

//https://leetcode.com/problems/merge-intervals
public class Solution
{
    public int[][] Merge(int[][] intervals)
    {
        if (intervals.Length <= 1)
        {
            return intervals;
        }
        var res = new List<int[]>();
        Array.Sort(intervals, (i, j) => i[0].CompareTo(j[0]));
        int[] newInterval = intervals[0];
        res.Add(newInterval);
        foreach (var interval in intervals)
        {
            if (interval[0] <= newInterval[1])
            {
                newInterval[1] = Math.Max(newInterval[1], interval[1]);
            }
            else
            {
                newInterval = interval;
                res.Add(newInterval);
            }
        }
        return res.ToArray();
    }
}