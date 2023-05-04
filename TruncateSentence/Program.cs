var solution = new Solution();
Console.WriteLine(solution.TruncateSentence("Hello how are you Contestant", 4));

// https://leetcode.com/problems/truncate-sentence
public class Solution
{
    public string TruncateSentence(string s, int k)
    {
        var arr = s.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        return string.Join(" ", arr.Take(k));
    }
}