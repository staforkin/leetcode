var solution = new Solution();
Console.WriteLine(solution.RemoveDuplicates(new int[] { 1 }));
Console.WriteLine(solution.RemoveDuplicates(new int[] { 1, 1, 1, 2, 2, 3 }));

// https://leetcode.com/problems/remove-duplicates-from-sorted-array-ii
public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        // 00 1111 2 33
        int length = nums.Length;
        int index = 0;
        int prevValue = int.MaxValue;
        int prevCount = 0;
        while (index < length && nums[index] > int.MinValue)
        {
            if (nums[index] == prevValue && prevCount == 2)
            {
                ShiftLeftFrom(nums, index);
                //Console.WriteLine(string.Join(";", nums));
            }
            else
            {
                if (nums[index] == prevValue)
                {
                    prevCount++;
                }
                else
                {
                    prevValue = nums[index];
                    prevCount = 1;
                }
                index++;
            }
        }
        //Console.WriteLine(string.Join(",", nums));
        return index;
    }

    private void ShiftLeftFrom(int[] arr, int from)
    {
        // 0 1 2 3
        // 0 2 3 -inf
        for (int i = from; i < arr.Length; i++)
        {
            if (arr[i] != int.MinValue && i < arr.Length - 1)
            {
                arr[i] = arr[i + 1];
            }
            else
            {
                arr[i] = int.MinValue;
            }
        }
    }
}