var solution = new Solution();
Console.WriteLine(solution.FindComplement(5));

// https://leetcode.com/problems/number-complement
public class Solution
{
    public int FindComplement(int num)
    {
        int i = 0;
        int j = 0;

        while (i < num)
        {
            i += (int)Math.Pow((double)2, (double)j);
            j++;
        }

        return i - num;
    }
}