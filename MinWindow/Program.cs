var solution = new Solution();
Console.WriteLine(solution.MinWindow("ADOBECODEBANC", "ABC"));

// https://leetcode.com/problems/minimum-window-substring
public class Solution
{
    public string MinWindow(string s, string t)
    {
        var arr = new int[128];
        foreach (var c in t)
        {
            arr[c]++;
        }
        int counter = t.Length,
        begin = 0, end = 0, minStart = 0, minLen = int.MaxValue;

        while (end < s.Length)
        {
            if (arr[s[end]] > 0) // if char in t exists in s
            {
                counter--;
            }
            arr[s[end]]--;
            end++;
            while (counter == 0) //valid - we found window
            {
                if (end - begin < minLen)
                {
                    minStart = begin;
                    minLen = end - begin;
                }
                arr[s[begin]]++;

                if (arr[s[begin]] > 0)
                {
                    counter++;// make invalid
                }
                begin++;
            }
        }
        return minLen == int.MaxValue ? "" : s.Substring(minStart, minLen);
    }
}