var solution = new Solution();
Console.WriteLine(solution.MinFlipsMonoIncr("0010110"));

// https://leetcode.com/problems/flip-string-to-monotone-increasing
public class Solution
{
    public int MinFlipsMonoIncr(string s)
    {
        // 0010110 (3/4) -> 0000111 (2)
        // 00011000 (2/6) -> 00000000 (2)

        int flipCount = 0;
        int onesCount = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '0')
            {
                if (onesCount == 0)
                {
                    continue;
                }
                else
                {
                    flipCount++;
                }
            }
            else
            {
                onesCount++;
            }
            if (flipCount > onesCount)
            {
                flipCount = onesCount;
            }
        }
        return flipCount;
    }
}