var solution = new Solution();
Console.WriteLine(solution.RemoveStars("leet**cod*e"));

// https://leetcode.com/problems/removing-stars-from-a-string
public class Solution
{
    public string RemoveStars(string s)
    {
        int j = 0;
        char[] ar = s.ToCharArray();
        for (int i = 0; i < s.Length; ++i)
        {
            if (ar[i] == '*')
            {
                j--;
            }
            else
            {
                ar[j++] = ar[i];
            }
        }
        s = new string(ar);
        return s.Substring(0, j);
    }
}