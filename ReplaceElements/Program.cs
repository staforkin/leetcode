var solution = new Solution();
Console.WriteLine(string.Join(",", solution.ReplaceElements(new[] { 17, 18, 5, 4, 6, 1 })));

// https://leetcode.com/problems/replace-elements-with-greatest-element-on-right-side
public class Solution
{
    public int[] ReplaceElements(int[] arr)
    {
        // 17 18 5 4 6 1
        var max = arr.Last();
        var res = new int[arr.Length];
        res[arr.Length - 1] = -1;
        for (int i = arr.Length - 2; i >= 0; i--)
        {
            res[i] = max;
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        return res;
    }
}