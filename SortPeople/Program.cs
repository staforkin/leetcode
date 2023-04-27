var solution = new Solution();
Console.WriteLine(string.Join(",", solution.SortPeople(new[] { "Alice","Bob","Bob" }, new[] { 155,185,150 })));

// https://leetcode.com/problems/sort-the-people
public class Solution
{
    public string[] SortPeople(string[] names, int[] heights)
    {
        var dict = new List<KeyValuePair<string, int>>();
        for (int i = 0; i < names.Length; i++)
        {
            dict.Add(new KeyValuePair<string, int>(names[i], heights[i]));
        }
        return dict.OrderByDescending(i => i.Value).Select(i => i.Key).ToArray();
    }
}