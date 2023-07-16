var solution = new Solution();
Console.WriteLine(string.Join(",", solution.NextGreaterElement(new[] { 4, 1, 2 }, new[] { 1, 3, 4, 2 })));

// https://leetcode.com/problems/next-greater-element-i/
public class Solution
{
    public int[] NextGreaterElement(int[] nums1, int[] nums2)
    {
        // 4 1 2
        // 1 3 4 2

        var map = new Dictionary<int, int>(); // map from x to next greater element of x
        var stack = new Stack<int>();
        foreach (int num in nums2)
        {
            while (stack.Any() && stack.Peek() < num)
            {
                map.Add(stack.Pop(), num);
            }
            stack.Push(num);
        }
        for (int i = 0; i < nums1.Length; i++)
        {
            nums1[i] = map.GetValueOrDefault(nums1[i], -1);
        }
        return nums1;
    }
}