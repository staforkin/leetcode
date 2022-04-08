var solution = new Solution();
var input = new int[] { 2, 0, 2, 1, 1, 0 };
solution.SortColors(input);
Console.WriteLine(string.Join(",", input));

//https://leetcode.com/problems/sort-colors
public class Solution
{
    public void SortColors(int[] nums)
    {
        if (nums == null || nums.Length < 2) return;
        int low = 0;
        int high = nums.Length - 1;
        for (int i = low; i <= high;)
        {
            if (nums[i] == 0)
            {
                int temp = nums[i];
                nums[i] = nums[low];
                nums[low] = temp;
                i++; low++;
            }
            else if (nums[i] == 2)
            {
                int temp = nums[i];
                nums[i] = nums[high];
                nums[high] = temp;
                high--;
            }
            else
            {
                i++;
            }
        }
    }

    private void PutNthToEnd(int[] nums, int idx)
    {
        var t = nums[idx];
        while (idx < nums.Length - 1)
        {
            nums[idx] = nums[idx + 1];
            idx++;
        }
        nums[idx] = t;
    }

    private void PutNthToBegining(int[] nums, int idx)
    {
        var t = nums[idx];
        while (idx > 0)
        {
            nums[idx] = nums[idx - 1];
            idx--;
        }
        nums[idx] = t;
    }
}