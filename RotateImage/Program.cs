var solution = new Solution();
var input = new int[][]{
    new int[]{1,2,3},
    new int[]{4,5,6},
    new int[]{7,8,9},
};
solution.Rotate(input);
foreach (var line in input)
{
    Console.WriteLine(string.Join(",", line));
}

//https://leetcode.com/problems/rotate-image/
public class Solution
{
    public void Rotate(int[][] matrix)
    {
        Array.Reverse(matrix);
        int n = matrix[0].Length;
        for (int i = 0; i < n; i++)
        {
            for (int j = i+1; j < n; j++)
            {
                int temp = matrix[j][i];
                matrix[j][i]=matrix[i][j];
                matrix[i][j] = temp;
            }
        }
    }
}