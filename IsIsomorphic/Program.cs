var solution = new Solution();
Console.WriteLine(solution.IsIsomorphic("egg", "add"));

// https://leetcode.com/problems/isomorphic-strings
public class Solution
{
    public bool IsIsomorphic(string s, string t)
    {
        // e g g
        // 

        int[] m1 = new int[256];
        int[] m2 = new int[256];
        int n = s.Length;
        for (int i = 0; i < n; ++i)
        {
            if (m1[s[i]] != m2[t[i]])
            {
                return false;
            }
            m1[s[i]] = i + 1;
            m2[t[i]] = i + 1;
        }
        return true;
    }
}