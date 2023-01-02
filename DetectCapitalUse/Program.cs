var solution = new Solution();
Console.WriteLine(solution.DetectCapitalUse("Google"));//true
Console.WriteLine(solution.DetectCapitalUse("FlaG"));//false
Console.WriteLine(solution.DetectCapitalUse("USA"));//true
Console.WriteLine(solution.DetectCapitalUse("gOOGLE"));//false
Console.WriteLine(solution.DetectCapitalUse("G"));//false

// https://leetcode.com/problems/detect-capital/
public class Solution
{
    public bool DetectCapitalUse(string word)
    {
        var isLower = char.IsLower(word[0]);
        if (isLower)
        {
            for (int i = 1; i < word.Length; i++)
            {
                if (!char.IsLower(word[i]))
                {
                    return false;
                }
            }
        }
        return AllCharsSameCase(word);
    }

    private bool AllCharsSameCase(string word)
    {
        if (word.Length == 1)
        {
            return true;
        }
        bool isLower = char.IsLower(word[1]);
        for (int i = 2; i < word.Length; i++)
        {
            var isL = char.IsLower(word[i]);
            if (isLower && !isL || !isLower && isL)
            {
                return false;
            }
        }
        return true;
    }
}