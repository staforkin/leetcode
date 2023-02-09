using System.Collections.Generic;

var solution = new Solution();
Console.WriteLine(solution.DistinctNames(new[] { "coffee", "donuts", "time", "toffee" }));

// https://leetcode.com/problems/naming-a-company
public class Solution
{
    public long DistinctNames(string[] ideas)
    {
        var count = new HashSet<int>[26];
        for (int i = 0; i < 26; ++i)
        {
            count[i] = new HashSet<int>();
        }
        foreach (var s in ideas)
        {
            count[s[0] - 'a'].Add(s.Substring(1).GetHashCode());
        }
        long res = 0;
        for (int i = 0; i < 26; ++i)
        {
            for (int j = i + 1; j < 26; ++j)
            {
                long c1 = 0, c2 = 0;
                foreach (int c in count[i])
                {
                    if (!count[j].Contains(c))
                    {
                        c1++;
                    }
                }
                foreach (int c in count[j])
                {
                    if (!count[i].Contains(c))
                    {
                        c2++;
                    }
                }
                res += c1 * c2;
            }
        }
        return res * 2;
    }
}