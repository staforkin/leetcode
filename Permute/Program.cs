var solution = new Solution();
foreach (var item in solution.Permute(new[] { 1, 2, 3 }))
{
    Console.WriteLine(string.Join(",", item));
}

//https://leetcode.com/problems/permutations/
public class Solution
{
    public IList<IList<int>> Permute(int[] nums)
    {
        var result = new List<IList<int>>();
        backTrack(result, new List<int>(),new HashSet<int>(), nums);
        return result;
    }

    private void backTrack(List<IList<int>> lists, List<int> tempList, HashSet<int> tmpSet, int[] nums)
    {
        if (tempList.Count == nums.Length)
        {
            lists.Add(new List<int>(tempList));
        }
        else
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (tmpSet.Contains(nums[i]))
                {
                    continue;
                }
                tmpSet.Add(nums[i]);
                tempList.Add(nums[i]);
                backTrack(lists, tempList, tmpSet, nums);
                int t = tempList.LastOrDefault();
                tempList.RemoveAt(tempList.Count() - 1);
                tmpSet.Remove(t);
            }
        }
    }
}