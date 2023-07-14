var solution = new Solution();
Console.WriteLine(solution.SpecialArray(new[] { 0, 4, 3, 0, 4 }));

// https://leetcode.com/problems/special-array-with-x-elements-greater-than-or-equal-x
public class Solution
{
    public int SpecialArray(int[] nums)
    {
        // 0 4 3 0 4
        // 0 0 3 4 4
        //     3

        int x = nums.Length;
        int[] counts = new int[x + 1];

        foreach (int elem in nums)
        {
            if (elem >= x)
            {
                counts[x]++;
            }
            else
            {
                counts[elem]++;
            }
        }

        int res = 0;
        for (int i = counts.Length - 1; i > 0; i--)
        {
            res += counts[i];
            if (res == i)
            {
                return i;
            }
        }

        return -1;
    }
}