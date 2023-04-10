var solution = new Solution();
Console.WriteLine(solution.IsValid("(([[{}]]))"));

//https://leetcode.com/problems/valid-parentheses/
public class Solution
{
    public bool IsValid(string s)
    {
        var stack = new Stack<char>();

        foreach (char ch in s)
        {
            switch (ch)
            {
                case '(':
                case '{':
                case '[':
                    stack.Push(ch);
                    break;

                case ')':
                    if (stack.Count == 0 || stack.Pop().ToString() != "(")
                    {
                        return false;
                    }
                    break;
                case '}':
                    if (stack.Count == 0 || stack.Pop().ToString() != "{")
                    {
                        return false;
                    }
                    break;
                case ']':
                    if (stack.Count == 0 || stack.Pop().ToString() != "[")
                    {
                        return false;
                    }
                    break;
            }

        }
        return stack.Count == 0;
    }
}