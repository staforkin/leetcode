using System.Text;

var solution = new Solution();
Console.WriteLine(solution.ReverseOnlyLetters("a-bC-dEf-ghIj"));

// https://leetcode.com/problems/reverse-only-letters
public class Solution
{
    public string ReverseOnlyLetters(string s)
    {
        StringBuilder sb = new StringBuilder(s);
        for (int i = 0, j = s.Length - 1; i < j;)
        {
            if (!char.IsLetter(sb[i]))
            {
                ++i;
            }
            else if (!char.IsLetter(sb[j]))
            {
                --j;
            }
            else
            {
                sb[i] = s[j];
                sb[j--] = s[i++];
            }
        }
        return sb.ToString();
    }
}