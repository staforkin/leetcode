var solution = new Solution();
//https://leetcode.com/problems/generate-parentheses
foreach (var item in solution.GenerateParenthesis(3))
{
    Console.WriteLine(item);
}

public class Solution
{
    public IList<string> GenerateParenthesis(int n)
    {
        var list = new List<string>();
        Backtrack(list, "", 0, 0, n);
        return list;
    }

    public void Backtrack(List<string> list, string str, int open, int close, int max)
    {
        if (str.Length == max * 2)
        {
            list.Add(str);
        }

        if (open < max)
        {
            Backtrack(list, str + "(", open + 1, close, max);
        }
        if (close < open)
        {
            Backtrack(list, str + ")", open, close + 1, max);
        }
    }
}