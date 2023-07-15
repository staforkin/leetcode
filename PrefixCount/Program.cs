var solution = new Solution();
Console.WriteLine(solution.PrefixCount(new[] { "bb", "cc", "dd", "ee" }, "a"));

// https://leetcode.com/problems/counting-words-with-a-given-prefix
public class Solution
{
    public int PrefixCount(string[] words, string pref)
    {
        int res = default;
        for (int i = 0; i < words.Length; i++)
        {
            var w = words[i];
            int r = 1;
            for (int j = 0; j < pref.Length; i++)
            {
                if (j > w.Length - 1 || pref[j] != w[j])
                {
                    r = 0;
                    break;
                }
            }
            res += r;
        }
        return res;
    }
}