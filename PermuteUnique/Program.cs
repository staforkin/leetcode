var solution = new Solution();
foreach (var item in solution.PermuteUnique(new[] { 1, 2, 3 }))
{
    Console.WriteLine(string.Join(",", item));
}

// https://leetcode.com/problems/permutations-ii
public class Solution
{
    public IList<IList<int>> PermuteUnique(int[] nums)
    {
        var res = new List<List<int>>();
        if (nums == null || nums.Length == 0)
        {
            return res.ToArray();
        }
        var used = new bool[nums.Length];
        var list = new List<int>();
        Array.Sort(nums);
        dfs(nums, used, list, res);
        return res.ToArray();
    }

    public void dfs(int[] nums, bool[] used, List<int> list, List<List<int>> res)
    {
        if (list.Count == nums.Length)
        {
            res.Add(new List<int>(list));
            return;
        }
        for (int i = 0; i < nums.Length; i++)
        {
            if (used[i])
            {
                continue;
            }
            if (i > 0 && nums[i - 1] == nums[i] && !used[i - 1])
            {
                continue;
            }
            used[i] = true;
            list.Add(nums[i]);
            dfs(nums, used, list, res);
            used[i] = false;
            list.RemoveAt(list.Count - 1);
        }
    }
}