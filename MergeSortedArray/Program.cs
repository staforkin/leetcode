var solution = new Solution();
var array = new[] { 1, 2, 3, 0, 0, 0 };
solution.Merge(array, 3, new[] { 2, 5, 6 }, 3);

Console.WriteLine(string.Join(",",array));

//https://leetcode.com/problems/merge-sorted-array/
public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        // 1 2 3 0 0 0
        // 2 5 6

        int i = m - 1, j = n - 1, k = m + n - 1;
        while (i >= 0 && j >= 0)
        {
            if (nums1[i] < nums2[j])
            {
                // assign to latest 0 and -- indeces
                nums1[k--] = nums2[j--];
            }
            else
            {
                nums1[k--] = nums1[i--];
            }
        }
        while (j >= 0)
        {
            nums1[k--] = nums2[j--];
        }
    }
}