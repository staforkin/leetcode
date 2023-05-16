var solution = new Solution();
Console.WriteLine(solution.SortSentence("is2 sentence4 This1 a3"));

// https://leetcode.com/problems/sorting-the-sentence
public class Solution
{
    public string SortSentence(string s)
    {
        var dict = s.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToDictionary(i => int.Parse(i.Last().ToString()), j => j[..^1]);
        return string.Join(" ", dict.OrderBy(i => i.Key).Select(i => i.Value));
    }
}