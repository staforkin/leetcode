var solution = new Solution();
Console.WriteLine(string.Join("", solution.CalcEquation(new[] { new[] { "a", "b" }, new[] { "b", "c" } }, new[] { 2.0, 3.0 }, new[]{
    new []{"a","c"},
    new []{"b","a"},
    new []{"a","e"},
    new []{"a","a"},
    new []{"x","x"}
})));

// https://leetcode.com/problems/evaluate-division
public class Solution
{
    public double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries)
    {

    }
}