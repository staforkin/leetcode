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
        var hs1 = nums1.ToHashSet();
        var res1 = new HashSet<int>();
        var hs2 = nums2.ToHashSet();
        var res2 = new HashSet<int>();
        for (int i = 0; i < nums1.Length; i++)
        {
            if (!hs2.Contains(nums1[i]))
            {
                res1.Add(nums1[i]);
            }
        }
        for (int i = 0; i < nums2.Length; i++)
        {
            if (!hs1.Contains(nums2[i]))
            {
                res2.Add(nums2[i]);
            }
        }
        return new[] { res1.ToArray(), res2.ToArray() };
    }
}