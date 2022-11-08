var solution = new Solution();
Console.WriteLine(solution.TitleToNumber("FXSHRXW"));

// https://leetcode.com/problems/excel-sheet-column-number
public class Solution
{
    public int TitleToNumber(string columnTitle)
    {
        // Z Y = 701
        // 26*26 + 25
        int res = default;
        int multiplier = 1;
        for (int i = columnTitle.Length - 1; i >= 0; i--)
        {
            res += multiplier * ((int)columnTitle[i]-64);
            multiplier = multiplier * 26;
        }
        return res;
    }
}