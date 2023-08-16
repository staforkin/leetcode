using System.Text;

var solution = new Solution();
Console.WriteLine(solution.RepeatedSubstringPattern("abab"));

// https://leetcode.com/problems/repeated-substring-pattern/
public class Solution
{
    public bool RepeatedSubstringPattern(string s)
    {
        int l = s.Length;
        for (int i = l / 2; i >= 1; i--)
        {
            if (l % i == 0)
            {
                int m = l / i;
                String subS = s.Substring(0, i);
                var sb = new StringBuilder();
                for (int j = 0; j < m; j++)
                {
                    sb.Append(subS);
                }
                if (sb.ToString().Equals(s))
                {
                    return true;
                }
            }
        }
        return false;
    }
}