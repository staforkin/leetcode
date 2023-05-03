var solution = new Solution();
foreach (var item in solution.FindDifference(new[] { 1, 2, 3 }, new[] { 2, 4, 6 }))
{
    Console.WriteLine(string.Join(",", item));
}

// https://leetcode.com/problems/find-the-difference-of-two-arrays
public class Solution
{
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
    {

    }
}