var solution = new Solution();
Console.WriteLine(solution.CloseStrings("abbzccca", "babzzczc"));
// https://leetcode.com/problems/determine-if-two-strings-are-close
public class Solution
{
    public bool CloseStrings(string word1, string word2)
    {
        // cabbba -> caabbb
        // caabbb -> baaccc
        // baaccc -> abbccc
        if (word1.Length != word2.Length)
        {
            return false;
        }
        var hs1 = new HashSet<char>(word1);
        var hs2 = new HashSet<char>(word2);
        if (hs1.Count != hs2.Count)
        {
            return false;
        }
        foreach (var c in hs1)
        {
            if (!hs2.Contains(c))
            {
                return false;
            }
        }
        int[] arr1 = new int[26];
        int[] arr2 = new int[26];
        for (int i = 0; i < word1.Length; i++)
        {
            arr1[word1[i] - 'a']++;
            arr2[word2[i] - 'a']++;
        }
        Array.Sort(arr1);
        Array.Sort(arr2);
        return arr1.SequenceEqual(arr2);
    }
}