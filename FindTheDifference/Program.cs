var solution = new Solution();
Console.WriteLine(solution.FindTheDifference("abcd", "abcde"));

// https://leetcode.com/problems/find-the-difference
public class Solution
{
    public char FindTheDifference(string s, string t)
    {
        char c = (char)0;
        foreach (char cs in s)
        {
            c ^= cs;
        }
        foreach (char ct in t)
        {
            c ^= ct;
        }
        return c;
    }
}