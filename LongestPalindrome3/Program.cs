var solution = new Solution();
Console.WriteLine(solution.LongestPalindrome("aa"));

// https://leetcode.com/problems/longest-palindrome
public class Solution
{
    public int LongestPalindrome(string s)
    {
        if (s == null || s.Length == 0)
        {
            return 0;
        }
        var hs = new HashSet<char>();
        int count = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (hs.Contains(s[i]))
            {
                hs.Remove(s[i]);
                count++;
            }
            else
            {
                hs.Add(s[i]);
            }
        }
        if (hs.Any())
        {
            return count * 2 + 1;
        }
        return count * 2;
    }
}