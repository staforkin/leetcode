var solution = new Solution();
Console.WriteLine(solution.WordPattern("abba", "dog cat cat dog"));

// https://leetcode.com/problems/word-pattern
public class Solution
{
    public bool WordPattern(string pattern, string s)
    {
        var arr = s.Split(" ");
        var map = new Dictionary<char, string>();
        if (arr.Length != pattern.Length)
        {
            return false;
        }
        for (int i = 0; i < arr.Length; i++)
        {
            char c = pattern[i];
            if (map.ContainsKey(c))
            {
                if (!map[c].Equals(arr[i]))
                {
                    return false;
                }
            }
            else
            {
                if (map.ContainsValue(arr[i]))
                {
                    return false;
                }
                map.Add(c, arr[i]);
            }
        }
        return true;
    }
}