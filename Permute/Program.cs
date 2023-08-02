var solution = new Solution();
foreach (var item in solution.Permute2(new[] { 1, 2, 3 }))
{
    Console.WriteLine(string.Join(",", item));
}

//https://leetcode.com/problems/permutations/
public class Solution
{
    private List<IList<int>> _result = new();
    public IList<IList<int>> Permute(int[] nums)
    {
        var result = new List<IList<int>>();
        backTrack(result, new List<int>(),new HashSet<int>(), nums);
        return result;
    }

    public IList<IList<int>> Permute2(int[] nums)
    {
        _result = new();
        MakePermutations(nums, 0, new int[nums.Length]);
        return _result;
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

    private void MakePermutations(int[] nums, int position, int[] permutation)
    {
        if (position == nums.Length)
        {
            _result.Add(new List<int>(permutation));
            return;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (Array.IndexOf(permutation, nums[i], 0, position) != -1)
            {
                continue;
            }

            permutation[position] = nums[i];
            MakePermutations(nums, position + 1, permutation);
        }
    }
}