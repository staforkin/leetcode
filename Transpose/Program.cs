var solution = new Solution();
var matrix = new int[][]{
    new []{1,2,3},
    new []{4,5,6},
    new []{7,8,9}};
foreach (var item in solution.Transpose(matrix))
{
    Console.WriteLine(string.Join(",", item));
}

// https://leetcode.com/problems/transpose-matrix/
public class Solution
{
    public int[][] Transpose(int[][] matrix)
    {
        int M = matrix.Length, N = matrix[0].Length;
        int[][] B = new int[N][];
        for (int i = 0; i < N; i++)
        {
            B[i] = new int[M];
        }
        for (int j = 0; j < N; j++)
        {
            for (int i = 0; i < M; i++)
            {
                B[j][i] = matrix[i][j];
            }
        }
        return B;
    }
}