var solution = new Solution();
foreach (var item in solution.FindAllConcatenatedWordsInADict(new[] { "cat", "cats", "catsdogcats", "dog", "dogcatsdog", "hippopotamuses", "rat", "ratcatdogcat" }))
{
    Console.WriteLine(item);
}

// https://leetcode.com/problems/concatenated-words
public class Solution
{
    public IList<string> FindAllConcatenatedWordsInADict(string[] words)
    {
        var result = new List<string>();
        var preWords = new HashSet<string>();
        Array.Sort(words, Comparer<string>.Create((a, b) => a.Length.CompareTo(b.Length)));
        for (int i = 0; i < words.Length; i++)
        {
            if (canForm(words[i], preWords))
            {
                result.Add(words[i]);
            }
            preWords.Add(words[i]);
        }

        return result;
    }

    private static bool canForm(String word, HashSet<string> dict)
    {
        if (!dict.Any())
        {
            return false;
        }
        bool[] dp = new bool[word.Length + 1];
        dp[0] = true;
        for (int i = 1; i <= word.Length; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (!dp[j])
                {
                    continue;
                }
                if (dict.Contains(word.Substring(j, i - j)))
                {
                    dp[i] = true;
                    break;
                }
            }
        }
        return dp[word.Length];
    }
}