using System.Text;

var solution = new Solution();
Console.WriteLine(solution.Multiply("24", "13"));

// https://leetcode.com/problems/multiply-strings
public class Solution
{
    public string Multiply(string num1, string num2)
    {
        // 24
        // 13 = 312
        int m = num1.Length, n = num2.Length;
        int[] pos = new int[m + n];

        for (int i = m - 1; i >= 0; i--)
        {
            for (int j = n - 1; j >= 0; j--)
            {
                int mul = (num1[i] - '0') * (num2[j] - '0');
                int p1 = i + j;
                int p2 = i + j + 1;
                int sum = mul + pos[p2];

                pos[p1] += sum / 10;
                pos[p2] = (sum) % 10;
            }
        }

        var sb = new StringBuilder();
        foreach (int p in pos)
        {
            if (!(sb.Length == 0 && p == 0))
            {
                sb.Append(p);
            }
        }
        return sb.Length == 0 ? "0" : sb.ToString();
    }
}