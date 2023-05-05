var solution = new Solution();
Console.WriteLine(solution.MaxVowels("abciiidef", 3));

// https://leetcode.com/problems/maximum-number-of-vowels-in-a-substring-of-given-length
public class Solution
{
    public int MaxVowels(string s, int k)
    {
        var res = 0;
        var vowels = new HashSet<char>() { 'a', 'e', 'i', 'o', 'u' };
        for (int i = 0, winCnt = 0; i < s.Length; ++i)
        {
            if (vowels.Contains(s[i]))
            {
                ++winCnt;
            }
            if (i >= k && vowels.Contains(s[i - k]))
            {
                --winCnt;
            }
            res = Math.Max(winCnt, res);
        }
        return res;
    }
}