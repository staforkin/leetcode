var solution = new Solution();
foreach (var item in solution.CombinationSum(new[] { 2, 3, 5 }, 8))
{
    Console.WriteLine(string.Join(",", item));
}

// https://leetcode.com/problems/combination-sum/
public class Solution
{
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        List<IList<int>> list = new List<IList<int>>();
        Array.Sort(candidates);
        backtrack(list, new List<int>(), candidates, target, 0);
        return list;
    }

    private void backtrack(List<IList<int>> list, List<int> tempList, int[] nums, int remain, int start)
    {
        if (remain < 0)
        {
            return;
        }
        else if (remain == 0)
        {
            list.Add(new List<int>(tempList));
        }
        else
        {
            for (int i = start; i < nums.Length; i++)
            {
                tempList.Add(nums[i]);
                backtrack(list, tempList, nums, remain - nums[i], i); // not i + 1 because we can reuse same elements
                tempList.RemoveAt(tempList.Count - 1);
            }
        }
    }
}