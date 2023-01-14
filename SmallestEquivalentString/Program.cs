using System.Text;

var solution = new Solution();
Console.WriteLine(solution.SmallestEquivalentString("parker", "morris", "parser"));

// https://leetcode.com/problems/lexicographically-smallest-equivalent-string
public class Solution
{
    public string SmallestEquivalentString(string s1, string s2, string baseStr)
    {
        int[] graph = new int[26];
        for (int i = 0; i < 26; i++)
        {
            graph[i] = i;
        }
        for (int i = 0; i < s1.Length; i++)
        {
            int a = s1[i] - 'a';
            int b = s2[i] - 'a';
            int end1 = find(graph, b);
            int end2 = find(graph, a);
            if (end1 < end2) // for saving lexicografic order
            {
                graph[end2] = end1;
            }
            else
            {
                graph[end1] = end2;
            }
        }

        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < baseStr.Length; i++)
        {
            char c = baseStr[i];
            sb.Append((char)('a' + find(graph, c - 'a')));
        }
        return sb.ToString();
    }

    private int find(int[] graph, int idx)
    {
        while (graph[idx] != idx)
        {
            idx = graph[idx];
        }
        return idx;
    }
}