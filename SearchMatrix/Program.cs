var solution = new Solution();
var matrix = new int[][]{new []{1,3,5,7},
new []{10,11,16,20},
new []{23,30,34,60}};
Console.WriteLine(solution.SearchMatrix(matrix, 3));

// https://leetcode.com/problems/search-a-2d-matrix
public class Solution
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        // 1    3   5   7
        // 10   11  16  20
        // 23   30  34  60

        //find row
        int rows = matrix.Length;
        int columns = matrix[0].Length;
        int targetRow = 0;
        for (int i = rows - 2; i >= 0; i--)
        {
            if (matrix[i][columns - 1] < target)
            {
                targetRow = i + 1;
                break;
            }
        }
        int res = Array.BinarySearch(matrix[targetRow], target);
        return res > -1;
        // n rows, m columns
        // O(n+logm)
        // can be improved with binary search of target row
        // same complexity as making plain list from the matrix
    }
}