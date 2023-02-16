var solution = new Solution();
Console.WriteLine(solution.ContainsNearbyDuplicate(new[] { 1, 2, 3, 1, 2, 3 }, 2));

// https://leetcode.com/problems/contains-duplicate-ii/
public class Solution
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        // 1 2 3 1 (4)
        var set = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (i > k)
            {
                set.Remove(nums[i - k - 1]);
            }
            if (!set.Add(nums[i]))
            {
                return true;
            }
        }
        return false;
    }
}