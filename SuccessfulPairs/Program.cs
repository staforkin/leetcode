var solution = new Solution();
Console.WriteLine(string.Join(",", solution.SuccessfulPairs(new[] { 2, 1, 2 }, new[] { 8, 5, 8 }, 16)));

// https://leetcode.com/problems/successful-pairs-of-spells-and-potions
public class Solution
{
    public int[] SuccessfulPairs(int[] spells, int[] potions, long success)
    {
        var spells0 = (int[])spells.Clone();
        Array.Sort(potions);
        Array.Sort(spells);
        var count = new Dictionary<int, int>();
        int n = spells.Length, m = potions.Length, j = m - 1;
        var res = new int[n];
        for (int i = 0; i < n; ++i)
        {
            while (j >= 0 && 1L * spells[i] * potions[j] >= success)
            {
                j--;
            }
            count.TryAdd(spells[i], m - j - 1);
        }
        for (int i = 0; i < n; ++i)
        {
            res[i] = count[spells0[i]];
        }
        return res;
    }
}