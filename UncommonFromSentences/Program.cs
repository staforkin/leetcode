var solution = new Solution();
foreach (var item in solution.UncommonFromSentences("this apple is sweet", "this apple is sour"))
{
    Console.WriteLine(item);
}

// https://leetcode.com/problems/uncommon-words-from-two-sentences/
public class Solution
{
    public string[] UncommonFromSentences(string s1, string s2)
    {
        var count = new Dictionary<string, int>();
        foreach (var w in (s1 + " " + s2).Split(" "))
        {
            if (count.ContainsKey(w))
            {
                count[w]++;
            }
            else
            {
                count.Add(w, 1);
            }
        }
        var res = new List<string>();
        foreach (var w in count.Keys)
        {
            if (count[w] == 1)
            {
                res.Add(w);
            }
        }
        return res.ToArray();
    }
}