var solution = new Solution();
Console.WriteLine(solution.CountOdds(4, 8));

// https://leetcode.com/problems/count-odd-numbers-in-an-interval-range
public class Solution
{
    public int CountOdds(int low, int high)
    {
        // 3 4 5 6 7
        // 3   5   7 = 3

        // 4 5 6 7 8
        //   5   7   = 2

        if (low % 2 == 0)
        {
            return (high - low + 1) / 2;
        }
        else
        {
            return (high - low) / 2 + 1;
        }
    }
}