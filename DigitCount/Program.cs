var solution = new Solution();
Console.WriteLine(solution.DigitCount("1210"));

// https://leetcode.com/problems/check-if-number-has-equal-digit-count-and-digit-value
public class Solution
{
    public bool DigitCount(string num)
    {
        for (int i = 0; i < num.Length; i++)
        {
            if (num.Count(a => a.ToString() == i.ToString()) != int.Parse(num[i].ToString()))
            {
                return false;
            }
        }
        return true;
    }
}