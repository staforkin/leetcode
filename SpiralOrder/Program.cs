var solution = new Solution();
Console.WriteLine(string.Join(",", solution.SpiralOrder(new[]{
    new []{1,2,3},
    new []{4,5,6},
    new []{7,8,9},
})));

//https://leetcode.com/problems/spiral-matrix
public class Solution
{
    public IList<int> SpiralOrder(int[][] matrix)
    {
        List<int> res = new List<int>();

        if (matrix.Length == 0)
        {
            return res;
        }
        int n = matrix.Length, m = matrix[0].Length;
        int up = 0, down = n - 1;
        int left = 0, right = m - 1;
        while (res.Count() < n * m)
        {
            for (int j = left; j <= right && res.Count() < n * m; j++)
                res.Add(matrix[up][j]);

            for (int i = up + 1; i <= down - 1 && res.Count() < n * m; i++)
                res.Add(matrix[i][right]);

            for (int j = right; j >= left && res.Count() < n * m; j--)
                res.Add(matrix[down][j]);

            for (int i = down - 1; i >= up + 1 && res.Count() < n * m; i--)
                res.Add(matrix[i][left]);

            left++; right--; up++; down--;
        }
        return res;
    }
}