var solution = new Solution();
Console.WriteLine(solution.reverseBits(2));

// https://leetcode.com/problems/reverse-bits
public class Solution
{
    public uint reverseBits(uint n)
    {
        if (n == 0) return 0;

        uint result = 0;
        for (int i = 0; i < 32; i++)
        {
            result <<= 1;
            if ((n & 1) == 1) result++;
            n >>= 1;
        }
        return result;
    }
}