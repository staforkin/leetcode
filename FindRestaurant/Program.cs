var solution = new Solution();
Console.WriteLine(string.Join(",", solution.FindRestaurant(new[] { "happy","sad","good" }, new[] { "sad","happy","good" })));

// https://leetcode.com/problems/minimum-index-sum-of-two-lists
public class Solution
{
    public string[] FindRestaurant(string[] list1, string[] list2)
    {
        var d1 = new Dictionary<string, int>();
        var d2 = new Dictionary<string, int>();
        var res = new Dictionary<string, int>();
        for (int i = 0; i < list1.Length; i++)
        {
            d1.Add(list1[i], i);
        }
        for (int i = 0; i < list2.Length; i++)
        {
            d2.Add(list2[i], i);
        }
        foreach (var item in d1)
        {
            if (d2.ContainsKey(item.Key))
            {
                res.Add(item.Key, item.Value + d2[item.Key]);
            }
        }
        return res.GroupBy(i => i.Value).OrderBy(i => i.Key).First().Select(i=>i.Key).ToArray();
    }
}