var solution = new Solution();
Console.WriteLine(solution.MyPow(2, 3) + " expect 8");
Console.WriteLine(solution.MyPow(2, -2) + " expect 0.25");
Console.WriteLine(solution.MyPow(2, -1) + " expect 0.5");
Console.WriteLine(solution.MyPow(2, 10) + " expect 1024");
Console.WriteLine(solution.MyPow(2, -2147483648) + " expect 0.00");

//https://leetcode.com/problems/powx-n/
public class Solution
{
    public double MyPow(double x, int n)
    {
        if (n == 0)
        {
            return 1;
        }
        if (n < 0)
        {
            x = 1/x;
            return (n % 2 == 0) ? MyPow(x * x, -(n / 2)) : x * MyPow(x * x, -(n / 2));
        }
        return (n % 2 == 0) ? MyPow(x * x, n / 2) : x * MyPow(x * x, n / 2);
    }
}