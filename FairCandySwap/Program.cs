var solution = new Solution();
Console.WriteLine(string.Join(",", solution.FairCandySwap(new[] { 1, 1 }, new[] { 2, 2 })));

// https://leetcode.com/problems/fair-candy-swap/
public class Solution
{
    public int[] FairCandySwap(int[] aliceSizes, int[] bobSizes)
    {
        int dif = (aliceSizes.Sum() - bobSizes.Sum()) / 2;
        var set = new HashSet<int>();
        foreach (int a in aliceSizes)
        {
            set.Add(a);
        }
        foreach (int b in bobSizes)
        {
            if (set.Contains(b + dif))
            {
                return new int[] { b + dif, b };
            }
        }
        return new int[0];
    }
}