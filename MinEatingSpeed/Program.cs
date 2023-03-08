var solution = new Solution();
Console.WriteLine(solution.MinEatingSpeed(new[] { 3, 6, 7, 11 }, 8));
Console.WriteLine(solution.MinEatingSpeed(new[] { 805_306_368, 805_306_368, 805_306_368 }, 1_000_000_000));

// https://leetcode.com/problems/koko-eating-bananas
public class Solution
{
    public int MinEatingSpeed(int[] piles, int h)
    {
        int lo = 1, hi = piles.Max();

        // Binary search to find the smallest valid K.
        while (lo <= hi)
        {
            int K = lo + ((hi - lo) >> 1);
            if (canEatAll(piles, K, h))
            {
                hi = K - 1;
            }
            else
            {
                lo = K + 1;
            }
        }

        return lo;
    }
    private bool canEatAll(int[] piles, int K, int H)
    {
        long countHour = 0; // Hours take to eat all bananas at speed K.

        foreach (int pile in piles)
        {
            countHour += pile / K;
            if (pile % K != 0)
                countHour++;
        }
        return countHour <= H;
    }
}