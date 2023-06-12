var solution = new Solution();
Console.WriteLine(solution.NumOfStrings(new[] { "a", "abc", "bc", "d" }, "abc"));

// https://leetcode.com/problems/number-of-strings-that-appear-as-substrings-in-word/
public class Solution
{
    public int NumOfStrings(string[] patterns, string word)
    {
        var hs = new HashSet<string>();
        for (int i = 0; i < word.Length; i++)
        {
            for (int j = i; j < word.Length; j++)
            {
                hs.Add(word.Substring(i, j - i + 1));
            }
        }
        return patterns.Count(i=>hs.Contains(i));
    }
}