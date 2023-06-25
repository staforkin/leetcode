var solution = new Solution();
Console.WriteLine(string.Join(",", solution.CommonChars(new[] { "bella", "label", "roller" }).ToArray()));

// https://leetcode.com/problems/find-common-characters
public class Solution
{
    public IList<string> CommonChars(string[] words)
    {
        int[] count = new int[26];
        Array.Fill(count, int.MaxValue);
        foreach (var item in words)
        {
            var c = new int[26];
            foreach (var i in item)
            {
                c[i - 'a']++;
            }
            for (int i = 0; i < 26; i++)
            {
                count[i] = Math.Min(c[i], count[i]);
            }
        }
        var res = new List<string>();
        for (char c = 'a'; c <= 'z'; ++c)
        {
            while (count[c - 'a']-- > 0)
            {
                res.Add("" + c);
            }
        }
        return res;
    }
}