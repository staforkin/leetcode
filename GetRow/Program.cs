﻿var solution = new Solution();
Console.WriteLine(string.Join(',', solution.GetRow(3)));

// https://leetcode.com/problems/pascals-triangle-ii
public class Solution
{
    public IList<int> GetRow(int rowIndex)
    {
        var arr = new int[rowIndex + 1];
        Array.Fill(arr, 0);
        arr[0] = 1;

        for (int i = 1; i <= rowIndex; i++)
        {
            for (int j = i; j > 0; j--)
            {
                arr[j] = arr[j] + arr[j - 1];
            }
        }
        return arr.ToList();
    }
}