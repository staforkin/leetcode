var solution = new Solution();
Console.WriteLine(solution.IsHappy(19));

// https://leetcode.com/problems/happy-number
public class Solution
{
    private readonly HashSet<int> _set = new HashSet<int>();
    public bool IsHappy(int n)
    {
        if (n == 1)
        {
            return true;
        }
        var sumOfSquares = SumOfSquares(n);
        if(_set.Contains(sumOfSquares)){
            return false;
        }
        _set.Add(sumOfSquares);
        Console.WriteLine(sumOfSquares);
        return IsHappy(sumOfSquares);
    }

    private int SumOfSquares(int n)
    {
        int res = default;
        // 100
        // 100 / 10 = 10 (0 as %)
        // 10 / 10 = 1 (0 as %)
        int left = default;
        do
        {
            left = n % 10;
            n=n/10;
            res += (int)Math.Pow(left, 2);

        } while (n >= 10);
        return res+(int)Math.Pow(n,2);
    }
}