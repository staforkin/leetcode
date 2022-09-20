using System.Collections.Generic;

var arr = new[] { 1, 2, 3 };
var solution = new Solution();
foreach (var r in solution.SubsetsBacktracked(arr))
{
    Console.WriteLine(string.Join(",", r));
}

//https://leetcode.com/problems/subsets/
public class Solution
{
    public IList<IList<int>> Subsets(int[] nums)
    {
        var result = new List<IList<int>>();
        result.Add(new List<int>());
        for (int n = 0; n < nums.Length; n++)
        {
            int size = result.Count();
            for (int i = 0; i < size; i++)
            {
                List<int> subset = new List<int>(result[i]);
                subset.Add(nums[n]);
                result.Add(subset);
            }
        }
        return result.ToArray();
    }

    public IList<IList<int>> SubsetsBacktracked(int[] nums)
    {
        var list = new List<IList<int>>();
        backtrack(list, new List<int>(), nums, 0);
        return list.ToArray();
    }

    private void backtrack(List<IList<int>> list, List<int> tempList, int[] nums, int start)
    {
        list.Add(new List<int>(tempList));
        for (int i = start; i < nums.Length; i++)
        {
            tempList.Add(nums[i]);
            backtrack(list, tempList, nums, i + 1);
            tempList.RemoveAt(tempList.Count() - 1);
        }
    }
}