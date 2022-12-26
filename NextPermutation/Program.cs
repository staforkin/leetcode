var solution = new Solution();
var arr = new int[] { 3, 2, 1 };
solution.NextPermutation(arr);
Console.WriteLine(string.Join(",", arr));
// https://leetcode.com/problems/next-permutation
public class Solution
{
    public void NextPermutation(int[] nums)
    {
        // https://leetcode.com/problems/next-permutation/solutions/13994/readable-code-without-confusing-i-j-and-with-explanation/?orderBy=most_votes
        int pivot = indexOfLastPeak(nums) - 1;

        if (pivot != -1)
        {
            int nextPrefix = lastIndexOfGreater(nums, nums[pivot]);
            swap(nums, pivot, nextPrefix);
        }
        reverseSuffix(nums, pivot + 1);
    }

    int indexOfLastPeak(int[] nums)
    {
        for (int i = nums.Length - 1; 0 < i; --i)
        {
            if (nums[i - 1] < nums[i]) return i;
        }
        return 0;
    }
    int lastIndexOfGreater(int[] nums, int threshold)
    {
        for (int i = nums.Length - 1; 0 <= i; --i)
        {
            if (threshold < nums[i]) return i;
        }
        return -1;
    }

    void swap(int[] nums, int i, int j)
    {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }

    void reverseSuffix(int[] nums, int start)
    {
        int end = nums.Length - 1;
        while (start < end)
        {
            swap(nums, start++, end--);
        }
    }
}