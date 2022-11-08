var solution = new Solution();
Console.WriteLine(solution.MissingNumber(new[] { 0, 1 }));

// https://leetcode.com/problems/missing-number
public class Solution
{
    public int MissingNumber(int[] nums)
    {
        var n = nums.Length;
        var etalon = Enumerable.Range(0, n + 1);
        var hashSet = nums.ToHashSet();
        foreach (var item in etalon)
        {
            if (!hashSet.Contains(item))
                return item;
        }
        return 0;
    }

    public int MissingNumber2(int[] nums)
    {
        int sum = nums.Length;
        for (int i = 0; i < nums.Length; i++)
            sum += i - nums[i];
        return sum;
    }
}