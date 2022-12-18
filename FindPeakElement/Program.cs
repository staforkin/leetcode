var solution = new Solution();
Console.WriteLine(solution.FindPeakElement(new[] { 1, 2, 4, 5, 1 }));

// https://leetcode.com/problems/find-peak-element
public class Solution
{
    public int FindPeakElement(int[] nums)
    {
        int n = nums.Length;
        if (n == 1)
        {
            return 0;
        }

        if (nums[0] > nums[1])
        {
            return 0;
        }

        if (nums[n - 1] > nums[n - 2])
        {
            return n - 1;
        }

        int start = 1;
        int end = n - 2;
        while (start <= end)
        {
            int mid = start + (end - start) / 2;
            if (nums[mid] > nums[mid - 1] && nums[mid] > nums[mid + 1])
            {
                return mid;
            }
            else if (nums[mid] < nums[mid - 1]) // peak is left to current mid
            {
                end = mid - 1;
            }
            else if (nums[mid] < nums[mid + 1])
            { //peak is right to current mid
                start = mid + 1;
            }
        }
        return -1;
    }
}