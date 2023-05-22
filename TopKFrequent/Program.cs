var solution = new Solution();
var res = solution.TopKFrequent2(new[] { 1, 1, 1, 2, 2, 3 }, 2);
Console.WriteLine(string.Join(",", res));

// https://leetcode.com/problems/top-k-frequent-elements
public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        var dict = new Dictionary<int, int>();
        foreach (var item in nums)
        {
            if (dict.ContainsKey(item))
            {
                dict[item]++;
            }
            else
            {
                dict.Add(item, 1);
            }
        }
        return dict.OrderByDescending(i => i.Value).Take(k).Select(i => i.Key).ToArray();
    }

    public int[] TopKFrequent2(int[] nums, int k)
    {
        return nums.GroupBy(x => x).OrderByDescending(y => y.Count()).Take(k).Select(z => z.Key).ToArray();
    }
}