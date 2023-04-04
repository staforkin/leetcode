var solution = new Solution();
Console.WriteLine(solution.PartitionStringFaster("abacaba"));

// https://leetcode.com/problems/optimal-partition-of-string
public class Solution
{
    public int PartitionString(string s)
    {
        var arr = new int[26];
        int res = 1;
        foreach (var c in s)
        {
            if (arr[c - 'a'] > 0)
            {
                res++;
                arr = new int[26];
                arr[c - 'a'] = 1;
            }
            else
            {
                arr[c - 'a'] = 1;
            }
        }
        return res;
    }

    public int PartitionStringFaster(string s)
    {
        var hs = new HashSet<char>();
        int count = 1;
        foreach (var ch in s)
        {
            if (hs.Contains(ch))
            {
                count++;
                hs.Clear();
            }
            hs.Add(ch);
        }
        return count;
    }
}