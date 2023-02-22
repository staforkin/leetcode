var solution = new Solution();
Console.WriteLine(solution.ShipWithinDays(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 5));
Console.WriteLine(solution.ShipWithinDays(new[] { 3, 2, 2, 4, 1, 4 }, 3));

// https://leetcode.com/problems/capacity-to-ship-packages-within-d-days
public class Solution
{
    public int ShipWithinDays(int[] weights, int days)
    {
        //  1 2 3 4 5 6 7 8 9 10
        // |1 2 3 4 5|6 7|8|9|10
        //  1 3 6 10 15 21 28 36 45 55

        //  3 2 2 4 1 4
        // |3 2|2 4|1 4
        //  3 5 7 11 12 16

        int left = weights.Max(), right = weights.Sum();
        // 10 and 55
        // mid = 32
        while (left < right)
        {
            int mid = (left + right) / 2, need = 1, cur = 0;
            foreach (int w in weights)
            {
                if (cur + w > mid)
                {
                    need += 1;
                    cur = 0;
                }
                cur += w;
            }
            if (need > days)
            {
                left = mid + 1;
            }
            else
            {
                right = mid;
            }
        }
        return left;
    }
}