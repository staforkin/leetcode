var solution = new Solution();
Console.WriteLine(string.Join(",", solution.FindAnagrams("baa", "aa")));

// https://leetcode.com/problems/find-all-anagrams-in-a-string
public class Solution
{
    public IList<int> FindAnagrams(string s, string p)
    {
        var result = new List<int>();
        var count = new int[26];
        Array.Fill(count, 0);
        var lenS = s.Length;
        var lenP = p.Length;
        if (lenP > lenS)
        {
            return Array.Empty<int>();
        }
        for (int i = 0; i < lenP; i++)
        {
            count[s[i] - 'a']++;
            count[p[i] - 'a']--;
        }
        if (AllZeroes(count))
        {
            result.Add(0);
        }
        for (int i = lenP; i < lenS; i++)
        {
            count[s[i] - 'a']++;
            count[s[i - lenP] - 'a']--;
            if (AllZeroes(count))
            {
                result.Add(i - lenP + 1);
            }
        }
        return result;
    }

    private bool AllZeroes(int[] arr)
    {
        return arr.All(i => i == 0);
    }
}