var solution = new Solution();
var array = new int[][] {
    new int[] { 2, 1, 3 },
    new int[] { 6, 5, 4 },
    new int[] { 7, 8, 9 }};

Console.WriteLine(solution.MinFallingPathSum(array));

// https://leetcode.com/problems/minimum-falling-path-sum
public class Solution
{
    public int MinFallingPathSum(int[][] matrix)
    {
        for (int i = 1; i < matrix.Length; ++i) // start from second row
        {
            for (int j = 0; j < matrix.Length; ++j)
            {
                matrix[i][j] += Math.Min(
                    matrix[i - 1][j], // above
                    Math.Min(matrix[i - 1][Math.Max(0, j - 1)], // up to the left
                    matrix[i - 1][Math.Min(matrix.Length - 1, j + 1)])); // up to the right
            }
        }
        return matrix.Last().Min();
    }
}