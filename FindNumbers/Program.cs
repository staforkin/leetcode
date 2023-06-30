var solution = new Solution();
Console.WriteLine(solution.FindNumbers(new[] { 1000 }));

// https://leetcode.com/problems/find-numbers-with-even-number-of-digits
public class Solution
{
    public int FindNumbers(int[] nums)
    {
        return nums.Count(i => IsEvenNumberOfDigits(i));
    }

    private bool IsEvenNumberOfDigits(int num)
    {
        var i = 1;
        while (num >= 10)
        {
            num /= 10;
            i++;
        }
        return i % 2 == 0;
    }
}