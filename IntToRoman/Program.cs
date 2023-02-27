using System.Text;

var solution = new Solution();
Console.WriteLine(solution.IntToRoman(58));
Console.WriteLine(solution.IntToRoman(3));
Console.WriteLine(solution.IntToRoman(1994));
Console.WriteLine(solution.IntToRoman(1000));
Console.WriteLine(solution.IntToRoman(2000));

// https://leetcode.com/problems/integer-to-roman
public class Solution
{
    public string IntToRoman(int num)
    {
        int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        string[] strs = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < values.Length; i++)
        {
            while (num >= values[i])
            {
                num -= values[i];
                sb.Append(strs[i]);
            }
        }
        return sb.ToString();
    }
}
