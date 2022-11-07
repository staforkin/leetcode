var solution = new Solution();
Console.WriteLine(solution.LongestPalindrome("babad"));
Console.WriteLine(solution.LongestPalindrome("cbbd"));

// https://leetcode.com/problems/longest-palindromic-substring/
public class Solution
{
    public string LongestPalindrome(string s)
    {
        int max = 0, idx = 0;
        for (int i = 0; i < s.Length; i++)
        {
            var len1 = extendPalindrome(s, i, i);
            var len2 = extendPalindrome(s, i, i + 1);
            if (max < Math.Max(len1, len2))
            {
                idx = (len1 > len2) ? (i - len1 / 2) : (i - len2 / 2 + 1);
                max = Math.Max(len1, len2);
                Console.WriteLine(s.Substring(idx, max));
            }
        }
        return s.Substring(idx, max);
    }

    private int extendPalindrome(string s, int i, int j)
    {
        for (; i >= 0 && j < s.Length; i--, j++)
        {
            Console.WriteLine($"s[i]={s[i]}, s[j]={s[j]}");
            if (s.ToCharArray()[i] != s.ToCharArray()[j])
                break;
        }
        return j - i - 2 + 1; // 2 means current two unmatched char
    }
}