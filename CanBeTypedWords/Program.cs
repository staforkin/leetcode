var solution = new Solution();
Console.WriteLine(solution.CanBeTypedWords("leet code", "e"));

// https://leetcode.com/problems/maximum-number-of-words-you-can-type/
public class Solution
{
    public int CanBeTypedWords(string text, string brokenLetters)
    {
        var hs = brokenLetters.ToHashSet();
        int cnt = 1;
        bool skipWord = false;
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == ' ')
            {
                skipWord = false;
                cnt++;
                continue;
            }
            if (hs.Contains(text[i]) && !skipWord)
            {
                cnt--;
                skipWord = true;
            }
        }
        return cnt;
    }
}