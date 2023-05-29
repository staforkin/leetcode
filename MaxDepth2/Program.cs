var solution = new Solution();
Console.WriteLine(solution.MaxDepth("(1+(2*3)+((8)/4))+1"));

// https://leetcode.com/problems/maximum-nesting-depth-of-the-parentheses
public class Solution
{
    public int MaxDepth(string s)
    {
        var q = new Queue<char>();
        int t = 0;
        int max = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == ')' && q.Peek() == '(')
            {
                q.Dequeue();
                t--;
            }
            else if (s[i] == '(' || s[i] == ')')
            {
                q.Enqueue(s[i]);
                if (s[i] == '(')
                {
                    t++;
                }
            }
            max = Math.Max(max, t);
        }
        return max;
    }
}