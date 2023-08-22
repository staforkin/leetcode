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

    }
}