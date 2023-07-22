var solution = new Solution();
Console.WriteLine(solution.FindContentChildren(new[] { 1, 2, 3 }, new[] { 1, 1 }));

// https://leetcode.com/problems/assign-cookies/
public class Solution
{
    public int FindContentChildren(int[] g, int[] s)
    {
        var pqKids = new PriorityQueue<int, int>();
        var pqCookies = new PriorityQueue<int, int>();
        int res = default;
        foreach (var i in g)
        {
            pqKids.Enqueue(i, i);
        }
        foreach (var i in s)
        {
            pqCookies.Enqueue(i, i);
        }
        while (pqCookies.Count > 0)
        {
            var cookie = pqCookies.Dequeue();
            if (pqKids.Count > 0 && cookie >= pqKids.Peek())
            {
                pqKids.Dequeue();
                res++;
            }
        }
        return res;
    }

    public int FindContentChildren2(int[] g, int[] s)
    {
        int i = 0;
        int j = 0;
        int count = 0;
        Array.Sort(g);
        Array.Sort(s);
        while (i < g.Length && j < s.Length)
        {
            if (s[j] >= g[i])
            {
                count++;
                i++;
            }
            j++;
        }
        return count;
    }
}