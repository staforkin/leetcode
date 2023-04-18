using System.Text;

var solution = new Solution();
Console.WriteLine(solution.MergeAlternately("abc", "pqr"));

// https://leetcode.com/problems/merge-strings-alternately
public class Solution
{
    public string MergeAlternately(string word1, string word2)
    {
        var n = word1.Length;
        var m = word2.Length;
        var i = 0;
        var j = 0;
        var sb = new StringBuilder();
        while (i < n || j < m)
        {
            if (i < n)
                sb.Append(word1[i++]);
            if (j < m)
                sb.Append(word2[j++]);
        }
        return sb.ToString();
    }
}