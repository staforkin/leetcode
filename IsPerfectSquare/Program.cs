var solution = new Solution();
Console.WriteLine(solution.IsPerfectSquare(16));

// https://leetcode.com/problems/valid-perfect-square
public class Solution
{
    public bool IsPerfectSquare(int num)
    {
        int i = 1;
        while (num > 0)
        {
            num -= i;
            i += 2;
        }
        return num == 0;
    }
}