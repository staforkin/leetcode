var solution = new Solution();
Console.WriteLine(solution.ThreeSumClosest(new[] { -1, 2, 1, -4 }, 2));

// https://leetcode.com/problems/3sum-closest
public class Solution
{
    public int ThreeSumClosest(int[] nums, int target)
    {
        Array.Sort(nums);
        var closest = 0;

        for (int i = 0, n = nums.Length, minDiff = int.MaxValue; i < n - 2; i++)
            for (int j = i + 1, k = n - 1; j < k;)
            {
                var sum = nums[i] + nums[j] + nums[k];

                if (sum == target)
                {
                    return target;
                }
                if (sum < target)
                {
                    j++;
                }
                else
                {
                    k--;
                }

                var diff = Math.Abs(target - sum);
                if (diff < minDiff)
                {
                    minDiff = diff;
                    closest = sum;
                }
            }
        return closest;
    }
}