var solution = new Solution();
Console.WriteLine(solution.HeightChecker(new[] { 1, 1, 4, 2, 1, 3 }));

// https://leetcode.com/problems/height-checker
public class Solution
{
    public int HeightChecker(int[] heights)
    {
        int[] heightToFreq = new int[101];

        foreach (int height in heights)
        {
            heightToFreq[height]++;
        }
        // 0 1 2 3 4 5
        // 1 1 4 2 1 3
        // 0 3 1 1 1 0

        int result = 0;
        int curHeight = 0;

        for (int i = 0; i < heights.Length; i++)
        {
            while (heightToFreq[curHeight] == 0)
            {
                curHeight++;
            }

            if (curHeight != heights[i])
            {
                result++;
            }
            heightToFreq[curHeight]--;
        }

        return result;
    }
}