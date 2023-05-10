var solution = new Solution();
foreach (var item in solution.GenerateMatrix(3))
{
    Console.WriteLine(string.Join("\t", item));
}

// https://leetcode.com/problems/spiral-matrix-ii
public class Solution
{
    public int[][] GenerateMatrix(int n)
    {
        var res = new int[n][];
        for (int i = 0; i < n; i++)
        {
            res[i] = new int[n];
        }

        int cur = 1;
        int rowBegin = 0;
        int rowEnd = n - 1;
        int colBegin = 0;
        int colEnd = n - 1;

        while (cur <= n * n)
        {
            int i = rowBegin;
            int j = colBegin;
            //left to right
            for (j = colBegin; j <= colEnd; j++)
            {
                res[rowBegin][j] = cur++;
            }
            rowBegin++;
            //top to bot
            for (i = rowBegin; i <= rowEnd; i++)
            {
                res[i][colEnd] = cur++;
            }
            colEnd--;
            //right to left
            for (j = colEnd; j >= colBegin; j--)
            {
                res[rowEnd][j] = cur++;
            }
            rowEnd--;
            //bot to top
            for (i = rowEnd; i >= rowBegin; i--)
            {
                res[i][colBegin] = cur++;
            }
            colBegin++;
        }
        return res;
    }
}