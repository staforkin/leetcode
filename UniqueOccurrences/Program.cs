﻿var solution = new Solution();
Console.WriteLine(solution.UniqueOccurrences(new[] { 1, 2, 2, 1, 1, 3 }));

// https://leetcode.com/problems/unique-number-of-occurrences/
public class Solution
{
    public bool UniqueOccurrences(int[] arr)
    {
        var g = arr.GroupBy(i=>i);
        return arr.Distinct().Count() == g.Select(i=>i.Count()).Distinct().Count();
    }
}