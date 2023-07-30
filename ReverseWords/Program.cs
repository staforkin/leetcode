using System.Text;

var solution = new Solution();
Console.WriteLine(solution.ReverseWords("Let's take LeetCode contest"));

// https://leetcode.com/problems/reverse-words-in-a-string-iii
public class Solution
{
    public string ReverseWords(string s)
    {
        var arr = s.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        var sb = new StringBuilder();
        foreach (var item in arr)
        {
            sb.Append(new string(item.Reverse().ToArray()) + " ");
        }
        sb.Remove(sb.Length - 1, 1);
        return sb.ToString();
    }
}