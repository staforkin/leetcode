using System.Text;

var solution = new Solution();
Console.WriteLine(solution.FreqAlphabets("10#11#12"));

// https://leetcode.com/problems/decrypt-string-from-alphabet-to-integer-mapping
public class Solution
{
    public string FreqAlphabets(string s)
    {
        var sb = new List<char>();
        for (int i = s.Length - 1; i >= 0;)
        {
            if (s[i] == '#')
            {
                var t = int.Parse(new[] { s[i - 2], s[i - 1] });
                sb.Add((char)(t - 1 + 'a'));
                i = i - 3;
            }
            else
            {
                var t = (char)(int.Parse(s[i].ToString()) - 1 + 'a');
                sb.Add(t);
                i--;
            }
        }
        sb.Reverse();
        return new string(sb.ToArray());
    }
}