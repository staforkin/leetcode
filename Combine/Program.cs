var solution = new Solution();
foreach (var item in solution.Combine(4, 2))
{
    Console.WriteLine(string.Join(",", item));
}

// https://leetcode.com/problems/combinations
public class Solution
{
    public IList<IList<int>> Combine(int n, int k)
    {
        var combs = new List<List<int>>();
        Comb(combs, new List<int>(), 1, n, k);
        return combs.ToArray();
    }

    private void Comb(List<List<int>> combs, List<int> comb, int start, int n, int k)
    {
        if (k == 0)
        {
            combs.Add(new List<int>(comb));
            return;
        }
        for (int i = start; i <= n; i++)
        {
            comb.Add(i);
            Comb(combs, comb, i + 1, n, k - 1);
            comb.RemoveAt(comb.Count - 1);
        }
    }
}