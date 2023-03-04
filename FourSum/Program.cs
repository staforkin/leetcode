var solution = new Solution();
foreach (var item in solution.FourSum(new[] { 1000000000, 1000000000, 1000000000, 1000000000 }, -294967296))
{
    Console.WriteLine(string.Join(",", item));
}

// https://leetcode.com/problems/4sum
public class Solution
{
    public IList<IList<int>> FourSum(int[] nums, int target)
    {
        var result = new List<List<int>>();
        if (nums == null || nums.Length == 0)
        {
            return result.ToArray();
        }
        int n = nums.Length;
        Array.Sort(nums);
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                long remainingSum = (long)target - nums[i] - nums[j];
                int left = j + 1;
                int right = n - 1;
                while (left < right)
                {
                    long curSum = nums[left] + nums[right];
                    if (curSum < remainingSum)
                    {
                        left++;
                    }
                    else if (curSum > remainingSum)
                    {
                        right--;
                    }
                    else
                    {
                        List<int> quad = new List<int>();
                        quad.Add(nums[i]);
                        quad.Add(nums[j]);
                        quad.Add(nums[left]);
                        quad.Add(nums[right]);
                        result.Add(quad);

                        while (left < right && nums[left] == quad[2])
                        {
                            ++left;//removing Duplicates for the left
                        }
                        while (left < right && nums[right] == quad[3])
                        {
                            --right;//removing Duplicates for the right
                        }
                    }
                }
                while (j + 1 < n && nums[j + 1] == nums[j])
                {
                    ++j;//Processing duplicates for j
                }
                while (i + 1 < n && nums[i + 1] == nums[i])
                {
                    ++i;     //Processing duplicates for i
                }
            }

        }
        return result.ToArray();
    }

}