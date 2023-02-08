using System.Text;

var solution = new Solution();
Console.WriteLine(solution.ConvertToTitle(28));

// https://leetcode.com/problems/excel-sheet-column-title
public class Solution
{
    public string ConvertToTitle(int columnNumber)
    {
        // 1 - A
        // 26 - Z
        // 27 - AA
        // 52 - AZ = 26 + 26
        // 53 - BA - 26 + 26 + 1
        //
        StringBuilder result = new StringBuilder();

        while (columnNumber > 0)
        {
            columnNumber--;
            result.Append((char)('A' + columnNumber % 26));
            columnNumber /= 26;
        }

        return new string(result.ToString().Reverse().ToArray());
    }
}