using System.Text;

var solution = new Solution();
foreach (var item in solution.SummaryRanges(new int[] { 0, 2, 3, 4, 6, 8, 9 }))
{
    Console.WriteLine(item);
}

// https://leetcode.com/problems/summary-ranges
public class Solution
{
    public IList<string> SummaryRanges(int[] nums)
    {
        // 0 1 2 4 5 7
        // 0 1 1 2 1 2

        // 0 2 3 4 6 8 9
        // 0 2 1 1 2 2 1

        var res = new List<string>();
        for (int i = 0; i < nums.Length; i++)
        {
            int start = nums[i];
            while (i + 1 < nums.Length && nums[i] + 1 == nums[i + 1])
            {
                i++;
            }

            if (start != nums[i])
            {
                res.Add($"{start}->{nums[i]}");
            }
            else
            {
                res.Add(start.ToString());
            }
        }
        return res;
    }
}