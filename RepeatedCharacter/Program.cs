var solution = new Solution();
Console.WriteLine(solution.RepeatedCharacter("abccbaacz"));

// https://leetcode.com/problems/first-letter-to-appear-twice
public class Solution
{
    public char RepeatedCharacter(string s)
    {
        var dict = new int[26];
        for (int i = 0; i < 26; i++)
        {
            dict[i] = 0;
        }
        for (int i = 0; i < s.Length; i++)
        {
            if (dict[s[i] - 'a'] > 0)
            {
                return s[i];
            }
            else
            {
                dict[s[i] - 'a']++;
            }
        }
        return default;
    }
}