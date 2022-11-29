using System.Text;

var solution = new Solution();
Console.WriteLine(solution.WordBreak("applepenapple", new[] { "apple", "pen" }));

// https://leetcode.com/problems/word-break
public class Solution
{
    public bool WordBreak(string s, IList<string> wordDict)
    {
        bool[] f = new bool[s.Length + 1];
        f[0] = true;

        for (int i = 1; i <= s.Length; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (f[j] && wordDict.Contains(s.Substring(j,i-j)))
                {
                    f[i] = true;
                    //Console.WriteLine($"i:{i}, j:{j}, {s.Substring(j,i-j)}");
                    break;
                }
            }
        }

        return f[s.Length];
    }
}