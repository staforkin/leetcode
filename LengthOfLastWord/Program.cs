var solution = new Solution();
Console.WriteLine(solution.LengthOfLastWord("Hello World "));

// https://leetcode.com/problems/length-of-last-word
public class Solution
{
    public int LengthOfLastWord(string s)
    {
        var arr = s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
        return arr.Last().Length;
    }
}