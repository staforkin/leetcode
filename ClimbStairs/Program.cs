var solution = new Solution();
Console.WriteLine(solution.ClimbStairs(45));

//https://leetcode.com/problems/climbing-stairs
public class Solution
{
    public int ClimbStairs(int n)
    {
        if (n <= 0) return 0;
        if (n == 1) return 1;
        if (n == 2) return 2;

        int one_step_before = 2;
        int two_steps_before = 1;
        int all_ways = 0;

        for (int i = 2; i < n; i++)
        {
            all_ways = one_step_before + two_steps_before;
            two_steps_before = one_step_before;
            one_step_before = all_ways;
        }
        return all_ways;
        //return Backtrack(n);
    }

    private int Backtrack(int n)
    {
        if (n < 2)
        {
            return 1;
        }
        return Backtrack(n - 2) + Backtrack(n - 1);
    }
}