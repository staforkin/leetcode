var solution = new Solution();
Console.WriteLine(solution.HammingDistance(1, 4));

// https://leetcode.com/problems/hamming-distance
public class Solution
{
    public int HammingDistance(int x, int y)
    {
        int d = 0;
        int bitxor = x ^ y;

        while (bitxor > 0)
        {
            if (bitxor % 2 == 1)
            {
                d++;
            }
            bitxor = bitxor >> 1;
        }

        return d;
    }
}