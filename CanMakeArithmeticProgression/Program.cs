var solution = new Solution();
Console.WriteLine(solution.CanMakeArithmeticProgression(new[] { 3, 5, 1 }));

// https://leetcode.com/problems/can-make-arithmetic-progression-from-sequence
public class Solution
{
    public bool CanMakeArithmeticProgression(int[] arr)
    {
        Array.Sort(arr);
        var d = arr[1] - arr[0];
        for (int i = 1; i < arr.Length - 1; i++)
        {
            if (arr[i + 1] - arr[i] != d)
            {
                return false;
            }
        }
        return true;
    }
}