var solution = new Solution();
Console.WriteLine(solution.NumWays(new[] { "acca", "bbbb", "caca" }, "aba"));

// https://leetcode.com/problems/number-of-ways-to-form-a-target-string-given-a-dictionary/
public class Solution
{
    public int NumWays(string[] words, string target)
    {
        int n = target.Length;
        long mod = (long)1e9 + 7;
        var res = new long[n + 1];
        res[0] = 1;
        for (int i = 0; i < words[0].Length; ++i)
        {
            int[] count = new int[26];
            foreach (var w in words)
            {
                count[w[i] - 'a']++;
            }
            for (int j = n - 1; j >= 0; --j)
            {
                res[j + 1] += res[j] * count[target[j] - 'a'] % mod;
            }
        }
        return (int)(res[n] % mod);
    }
}