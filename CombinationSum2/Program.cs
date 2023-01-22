var solution = new Solution();
foreach (var item in solution.CombinationSum2(new[] { 10, 1, 2, 7, 6, 1, 5 }, 8))
{
    Console.WriteLine(string.Join(",", item));
}

// https://leetcode.com/problems/combination-sum-ii
public class Solution
{
    public IList<IList<int>> CombinationSum2(int[] candidates, int target)
    {
        List<IList<int>> list = new List<IList<int>>();
        Array.Sort(candidates);
        backtrack(list, new List<int>(), candidates, target, 0);
        return list;
    }

    private void backtrack(List<IList<int>> list, List<int> tempList, int[] cand, int remain, int start)
    {
        if (remain < 0) //overflow
        {
            return;
        }
        else if (remain == 0) // match
        {
            list.Add(new List<int>(tempList));
        }
        else
        {
            for (int i = start; i < cand.Length; i++)
            {
                if (i > start && cand[i] == cand[i - 1]) continue; /** skip duplicates */
                if (remain - cand[i] < 0) break;
                tempList.Add(cand[i]);
                backtrack(list, tempList, cand, remain - cand[i], i + 1);
                tempList.RemoveAt(tempList.Count - 1);
            }
        }
    }
}