var solution = new Solution();
Console.WriteLine(solution.NumIdenticalPairs(new[] { 1, 2, 3, 1, 1, 3 }));

// https://leetcode.com/problems/number-of-good-pairs
public class Solution
{
    public int NumIdenticalPairs(int[] nums)
    {
        var dict = new Dictionary<int, int>();

        int ans = 0;

        foreach (int i in nums)
        {
            int count = dict.GetValueOrDefault(i, 0);
            ans += count;
            if (dict.ContainsKey(i))
            {
                dict[i] = count + 1;
            }
            else
            {
                dict.Add(i, count + 1);
            }
        }
        return ans;
    }
}