var solution = new Solution();
Console.WriteLine(solution.AreOccurrencesEqual("abacbc"));

// https://leetcode.com/problems/check-if-all-characters-have-equal-number-of-occurrences
public class Solution
{
    public bool AreOccurrencesEqual(string s)
    {
        var dict = s.GroupBy(i => i);
        var c = dict.FirstOrDefault().Count();
        foreach (var d in dict)
        {
            if (d.Count() != c)
            {
                return false;
            }
        }
        return true;
    }
}