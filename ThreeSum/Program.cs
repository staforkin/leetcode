var solution = new Solution();
foreach (var s in solution.ThreeSum(new[] { -1, 0, 1, 2, -1, -4 }))
{
    Console.WriteLine(string.Join(',', s));
}

//https://leetcode.com/problems/3sum
public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        var res = new List<IList<int>>();
        Array.Sort(nums);
        for (int i = 0; i < nums.Length - 2; i++)
        {
            if (i > 0 && nums[i - 1] == nums[i]) continue;
            int j = i + 1;
            int k = nums.Length - 1;
            while (j < k)
            {
                int sum = nums[i] + nums[j] + nums[k];
                if (sum == 0)
                {
                    res.Add(new List<int>() { nums[i], nums[j], nums[k] });
                    while (j < k && nums[j] == nums[j + 1]) j++;
                    while (j < k && nums[k] == nums[k - 1]) k--;
                    j++;
                    k--;
                }
                else if (sum > 0)
                {
                    k--;
                }
                else if (sum < 0)
                {
                    j++;
                }
            }
        }
        return res.ToArray();
    }
}