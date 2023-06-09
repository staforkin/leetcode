var solution = new Solution();
Console.WriteLine(solution.NextGreatestLetter(new[] { 'c', 'f', 'j' }, 'c'));

// https://leetcode.com/problems/find-smallest-letter-greater-than-target
public class Solution
{
    public char NextGreatestLetter(char[] letters, char target)
    {
        var arr = new int[26];
        int j = target - 'a';
        int min = Int32.MaxValue;
        for (int i = 0; i < letters.Length; i++)
        {
            int t = letters[i] - 'a';
            if (t > j && i < min)
            {
                min = i;
            }
        }
        return min < Int32.MaxValue ? letters[min] : letters[0];
    }
}