var solution = new Solution();
Console.WriteLine(solution.CanConstruct("aa", "aab"));

// https://leetcode.com/problems/ransom-note
public class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        var mag = new Dictionary<char, int>();
        for (int i = 0; i < magazine.Length; i++)
        {
            if (mag.ContainsKey(magazine[i]))
            {
                mag[magazine[i]]++;
            }
            else
            {
                mag.Add(magazine[i], 1);
            }
        }
        foreach (var c in ransomNote)
        {
            if (mag.ContainsKey(c) && mag[c] > 0)
            {
                mag[c]--;
            }
            else
            {
                return false;
            }
        }
        return true;
    }
}