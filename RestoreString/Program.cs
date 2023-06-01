var solution = new Solution();
Console.WriteLine(solution.RestoreString("codeleet", new[] { 4, 5, 6, 7, 0, 2, 1, 3 }));

// https://leetcode.com/problems/shuffle-string
public class Solution
{
    public string RestoreString(string s, int[] indices)
    {
        char[] res = new char[s.Length];
        for (int i = 0; i < s.Length; i++)
        {
            res[indices[i]] = s[i];
        }
        return new string(res);
    }
}