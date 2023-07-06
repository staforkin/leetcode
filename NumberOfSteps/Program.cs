var solution = new Solution();
Console.WriteLine(solution.NumberOfSteps(14));

// https://leetcode.com/problems/number-of-steps-to-reduce-a-number-to-zero
public class Solution
{
    public int NumberOfSteps(int num)
    {
        int res = 0;
        while (num > 0)
        {
            if (num % 2 == 0)
            {
                num = num / 2;
            }
            else
            {
                num--;
            }
            res++;
        }
        return res;
    }
}