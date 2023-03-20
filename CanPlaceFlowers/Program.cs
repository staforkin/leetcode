var solution = new Solution();
Console.WriteLine(solution.CanPlaceFlowers(new[] { 1, 0, 0, 0, 1 }, 1));

// https://leetcode.com/problems/can-place-flowers/
public class Solution
{
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        // 1 0 0 0 1
        int count = 0;
        for (int i = 0; i < flowerbed.Length && count < n; i++)
        {
            if (flowerbed[i] == 0)
            {
                int next = (i == flowerbed.Length - 1) ? 0 : flowerbed[i + 1];
                int prev = (i == 0) ? 0 : flowerbed[i - 1];
                if (next == 0 && prev == 0)
                {
                    flowerbed[i] = 1;
                    count++;
                }
            }
        }
        return count == n;
    }
}