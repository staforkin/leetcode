var solution = new Solution();
Console.WriteLine(solution.LongestCommonSubsequence("abcde", "gcef"));

// https://leetcode.com/problems/longest-common-subsequence/
public class Solution
{
    public int LongestCommonSubsequence(string text1, string text2)
    {

        //   a b c d e
        // g     c   e f
        var m = new short[1001][];
        for (int i = 0; i < 1001; i++)
        {
            m[i] = new short[1001];
        }
        for (int i = 0; i < text1.Length; ++i)
        {
            for (int j = 0; j < text2.Length; ++j)
            {
                m[i + 1][j + 1] = (short)(text1[i] == text2[j] ? m[i][j] + (short)1 : (short)Math.Max(m[i + 1][j], m[i][j + 1]));
            }
        }

        return m[text1.Length][text2.Length];
    }
}