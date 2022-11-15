var solution = new Solution();
Console.WriteLine(solution.IsPowerOfThree(81));
// https://leetcode.com/problems/power-of-three
public class Solution
{
    public bool IsPowerOfThree(int n)
    {
        return (n > 0 && 1162261467 % n == 0);
    }
}