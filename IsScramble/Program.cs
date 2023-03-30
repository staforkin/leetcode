using System.Text;

var solution = new Solution();
Console.WriteLine(solution.IsScramble("great", "rgeat"));

// https://leetcode.com/problems/scramble-string
public class Solution
{
    public Dictionary<string, bool> map = new Dictionary<string, bool>();
    public bool IsScramble(string s1, string s2)
    {
        var sb = new StringBuilder();
        sb.Append(s1);
        sb.Append(s2);
        String key = sb.ToString();

        if (map.ContainsKey(key))
        {
            return map[key];
        }

        if (s1.Equals(s2))
        {
            map.Add(key, true);
            return true;
        }

        int[] letters = new int[26];
        for (int i = 0; i < s1.Length; i++)
        {
            letters[s1[i] - 'a']++;
            letters[s2[i] - 'a']--;
        }
        for (int i = 0; i < 26; i++)
        {
            if (letters[i] != 0)
            {
                map.Add(key, false);
                return false;
            }
        }

        for (int i = 1; i < s1.Length; i++)
        {
            if (IsScramble(s1.Substring(0, i), s2.Substring(0, i))
               && IsScramble(s1.Substring(i), s2.Substring(i)))
            {
                map.Add(key, true);
                return true;
            }

            if (IsScramble(s1.Substring(0, i), s2.Substring(s1.Length - i))
               && IsScramble(s1.Substring(i), s2.Substring(0, s1.Length - i)))
            {
                map.Add(key, true);
                return true;
            }
        }

        map.Add(key, false);
        return false;
    }
}