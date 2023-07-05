var solution = new Solution();
Console.WriteLine(solution.RemoveDuplicates("bbaaca"));

// https://leetcode.com/problems/remove-all-adjacent-duplicates-in-string
public class Solution
{
    public string RemoveDuplicates(string s)
    {
        // abbaca
        int i = 0, n = s.Length;
        char[] res = s.ToCharArray();
        for (int j = 0; j < n; ++j, ++i)
        {
            res[i] = res[j];
            if (i > 0 && res[i - 1] == res[i]) // count = 2
                i -= 2;
        }
        return new String(res, 0, i);
    }
}