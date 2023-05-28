var solution = new Solution();
Console.WriteLine(solution.CheckIfPangram("thequickbrownfoxjumpsoverthelazydog"));

// https://leetcode.com/problems/check-if-the-sentence-is-pangram
public class Solution
{
    public bool CheckIfPangram(string sentence)
    {
        var arr = new int[26];
        for (int i = 0; i < sentence.Length; i++)
        {
            arr[sentence[i] - 'a']++;
        }
        return !arr.Any(i => i == 0);
    }
}