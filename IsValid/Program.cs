var solution = new Solution();
Console.WriteLine(solution.IsValid("(([[{}]]))"));

//https://leetcode.com/problems/valid-parentheses/
public class Solution
{
    public bool IsValid(string s)
    {
        var stack = new Stack<char>();

        for (int i = 0; i < s.Length; i++)
        {
            if (stack.Count == 0)
            {
                stack.Push(s[i]);
            }
            else
            {
                switch (stack.Peek())
                {
                    case '(':
                        if(s[i]==')')
                            stack.Pop();
                        else
                            stack.Push(s[i]);
                        break;
                    case '{':
                        if(s[i]=='}')
                            stack.Pop();
                        else
                            stack.Push(s[i]);
                        break;
                    case '[':
                        if(s[i]==']')
                            stack.Pop();
                        else
                            stack.Push(s[i]);
                        break;
                    default:
                        stack.Push(s[i]);
                        break;
                }
            }

        }
        return stack.Count == 0;
    }
}