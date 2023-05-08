var solution = new Solution();
var matrix = new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } };
Console.WriteLine(solution.DiagonalSum(matrix));

// https://leetcode.com/problems/matrix-diagonal-sum
public class Solution
{
    public int DiagonalSum(int[][] mat)
    {
        //0 0
        //1 1
        //2 2

        // 0 2
        // 1 1
        // 2 0
        int n = mat.Length;
        int res = 0;

        for (int jl = 0, jr = n - 1; jl < n; jl++, jr--)
        {
            if (jl == jr)
            {
                res += mat[jl][jl];
            }
            else
            {
                res = res + mat[jl][jl] + mat[jl][jr];
            }
        }

        return res;
    }
}