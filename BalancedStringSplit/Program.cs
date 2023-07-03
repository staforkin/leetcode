var solution = new Solution();
Console.WriteLine(solution.BalancedStringSplit("RLRRLLRLRL"));

// https://leetcode.com/problems/split-a-string-in-balanced-strings
public class Solution
{
    public int BalancedStringSplit(string s)
    {
        int i = 0;
        int res = 0;
        foreach (var c in s)
        {
            if (c == 'L')
            {
                i--;
            }
            else
            {
                i++;
            }
            if (i == 0)
            {
                res++;
            }
        }
        return res;
    }
}