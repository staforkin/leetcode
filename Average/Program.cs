var solution = new Solution();
Console.WriteLine(solution.Average(new[] { 4000, 3000, 1000, 2503 }).ToString("N5"));

// https://leetcode.com/problems/average-salary-excluding-the-minimum-and-maximum-salary
public class Solution
{
    public double Average(int[] salary)
    {
        double res = 0;
        var n = salary.Length - 2;
        var max = salary.Max();
        var min = salary.Min();
        foreach (var item in salary)
        {
            if (item != min && item != max)
            {
                res += (double)((double)item / n);
            }
        }
        return res;
    }
}