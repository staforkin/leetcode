var solution = new Solution();
Console.WriteLine(solution.CountConsistentStrings("ab", new[] { "ad", "bd", "aaab", "baa", "badab" }));

// https://leetcode.com/problems/count-the-number-of-consistent-strings
public class Solution
{
    public int CountConsistentStrings(string allowed, string[] words)
    {
        var hs = allowed.ToHashSet();
        int res = default;
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].All(i => hs.Contains(i)))
            {
                res++;
            }
        }
        return res;
    }
}