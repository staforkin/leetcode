var solution = new Solution();
Console.WriteLine(solution.EvalRPN(new[] { "4", "13", "5", "/", "+" }));

// https://leetcode.com/problems/evaluate-reverse-polish-notation/
public class Solution
{
    public int EvalRPN(string[] tokens)
    {
        int a, b;
        Stack<int> stack = new Stack<int>();
        foreach (var s in tokens)
        {
            switch (s)
            {
                case "+":
                    stack.Push(stack.Pop() + stack.Pop());
                    break;
                case "-":
                    b = stack.Pop();
                    a = stack.Pop();
                    stack.Push(a - b);
                    break;
                case "*":
                    stack.Push(stack.Pop() * stack.Pop());
                    break;
                case "/":
                    b = stack.Pop();
                    a = stack.Pop();
                    stack.Push(a / b);
                    break;
                default:
                    stack.Push(int.Parse(s));
                    break;
            }
        }
        return stack.Pop();
    }
}