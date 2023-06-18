var solution = new Solution();
Console.WriteLine(solution.Fib(2));

// https://leetcode.com/problems/fibonacci-number
public class Solution
{
    public int Fib(int n)
    {
        if (n <= 1)
        {
            return n;
        }

        int a = 0, b = 1;

        while (n-- > 1)
        {
            int sum = a + b;
            a = b;
            b = sum;
        }
        return b;
    }
}