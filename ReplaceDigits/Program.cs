var solution = new Solution();
Console.WriteLine(solution.ReplaceDigits("a1c1e1"));

// https://leetcode.com/problems/replace-all-digits-with-characters/
public class Solution
{
    public string ReplaceDigits(string s)
    {
        var res = s.ToArray();
        for (int i = 1; i < s.Length; i += 2)
        {
            res[i] = (char)(res[i - 1] + res[i] - '0');
        }
        return new string(res);
    }
}