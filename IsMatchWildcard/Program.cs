var solution = new Solution();
Console.WriteLine(solution.IsMatch("abcdefx", "a*ef*") + " expected True");
Console.WriteLine(solution.IsMatch("abcde", "a??e") + " expected False");

//https://leetcode.com/problems/wildcard-matching
public class Solution
{
    public bool IsMatch(string s, string p)
    {
        // afjkb n=5
        // *a*b n=4  a???b n=5
        int sCarret = 0, pCarret = 0, match = 0, starIdx = -1;
        while (sCarret < s.Length)
        {
            if (pCarret < p.Length && (p[pCarret] == '?' || s[sCarret] == p[pCarret]))
            {
                sCarret++;
                pCarret++;
            }
            else if (pCarret < p.Length && p[pCarret] == '*')
            {
                starIdx = pCarret;
                match = sCarret;
                pCarret++;
            }
            else if (starIdx != -1)
            {
                pCarret = starIdx + 1;
                match++;
                sCarret = match;
            }
            else return false;
        }
        while (pCarret < p.Length && p[pCarret] == '*')
            pCarret++;

        return pCarret == p.Length;
    }
}