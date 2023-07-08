var solution = new Solution();
Console.WriteLine(solution.Maximum69Number(9669));

// https://leetcode.com/problems/maximum-69-number
public class Solution
{
    public int Maximum69Number(int num)
    {
        var s = num.ToString().Select(i => i - '0').ToArray();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == 6)
            {
                s[i] = 9;
                break;
            }
        }
        return int.Parse(string.Join(null, s));
    }
}