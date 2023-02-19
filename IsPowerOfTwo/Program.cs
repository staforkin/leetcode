var solution = new Solution();
Console.WriteLine(solution.IsPowerOfTwo(0));

// https://leetcode.com/problems/power-of-two
public class Solution
{
    public bool IsPowerOfTwo(int n)
    {
        if (n <= 0)
        {
            return false;
        }
        while (n % 2 == 0)
        {
            n = n / 2;
            Console.WriteLine(n);
        }
        return n == 1;
    }
}