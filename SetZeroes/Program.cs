var solution = new Solution();
var input = new[]{
    new int[]{1,1,1},
    new int[]{1,0,1},
    new int[]{1,1,1},
};
solution.SetZeroes(input);
foreach (var line in input)
{
    Console.WriteLine(string.Join(",", line));
}

//https://leetcode.com/problems/set-matrix-zeroes/
public class Solution
{
    public void SetZeroes(int[][] matrix)
    {
        int col0 = 1, rows = matrix.Length, cols = matrix[0].Length;
        for (int i = 0; i < rows; i++)
        {
            if (matrix[i][0] == 0) col0 = 0;
            for (int j = 1; j < cols; j++)
                if (matrix[i][j] == 0)
                    matrix[i][0] = matrix[0][j] = 0;
        }

        for (int i = rows - 1; i >= 0; i--)
        {
            for (int j = cols - 1; j >= 1; j--)
                if (matrix[i][0] == 0 || matrix[0][j] == 0)
                    matrix[i][j] = 0;
            if (col0 == 0) matrix[i][0] = 0;
        }
    }
}