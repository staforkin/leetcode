var solution = new Solution();
Console.WriteLine(string.Join(",", solution.SortArray(new[] { 5, 2, 3, 1 })));

// https://leetcode.com/problems/sort-an-array
public class Solution
{
    public int[] SortArray(int[] nums)
    {
        var res = new List<int>();
        if (nums == null || nums.Length == 0)
        {
            return res.ToArray();
        }
        quickSort(nums, 0, nums.Length - 1);
        foreach (int i in nums)
        {
            res.Add(i);
        }
        return res.ToArray();
    }

    private void quickSort(int[] nums, int l, int r)
    {
        if (l >= r)
        {
            return;
        }
        int mid = partition(nums, l, r);
        quickSort(nums, l, mid);
        quickSort(nums, mid + 1, r);
    }

    private int partition(int[] nums, int l, int r)
    {
        int pivot = nums[l];
        while (l < r)
        {
            while (l < r && nums[r] >= pivot) r--;
            nums[l] = nums[r];
            while (l < r && nums[l] <= pivot) l++;
            nums[r] = nums[l];
        }
        nums[l] = pivot;
        return l;
    }
}

/*
public class Solution 
{
    public int[] SortArray(int[] nums) 
    {
        CountingSort(nums);

        return nums;
    }

    private void CountingSort(int[] nums)
    {
        var min = nums.Min();

        if (min >= 0)
        {
            CountingSortWithPositive(nums);
            return;
        }

        CountingSortWithNegative(nums, min);
    }

    private void CountingSortWithPositive(int[] nums)
    {
        var counter = new int[nums.Max() + 1];

        for (var i = 0; i < nums.Length; i++)
            counter[nums[i]]++;

        for (int i = 0, i_num = 0; i < counter.Length; i++)
            for (var j = 0; j < counter[i]; j++, i_num++)
                nums[i_num] = i;
    }

    private void CountingSortWithNegative(int[] nums, int min)
    {
        var minAbs = Math.Abs(min);
        var counter = new int[nums.Max() + 1 + minAbs];

        for (var i = 0; i < nums.Length; i++)
            counter[nums[i] + minAbs]++;

        for (int i = 0, i_num = 0; i < counter.Length; i++)
            for (var j = 0; j < counter[i]; j++, i_num++)
                nums[i_num] = i - minAbs;
    }
}
*/