var solution = new Solution();
//var matrix = new int[][] { new[] { 1, 2 }, new[] { 1, 3 } };
var matrix = new int[][] { new[] { 1, 5, 9 }, new[] { 10, 11, 13 }, new[] { 12, 13, 15 } };

Console.WriteLine(solution.KthSmallest(matrix, 8));

// https://leetcode.com/problems/kth-smallest-element-in-a-sorted-matrix/
public class Solution
{
    public int KthSmallest(int[][] matrix, int k)
    {
        int m = matrix.Length, n = matrix[0].Length; // For general, the matrix need not be a square
        var maxHeap = new PriorityQueue<int, int>(new CustomComparer());
        for (int r = 0; r < m; ++r)
        {
            for (int c = 0; c < n; ++c)
            {
                maxHeap.Enqueue(matrix[r][c], matrix[r][c]);
                if (maxHeap.Count > k)
                { maxHeap.Dequeue(); }
            }
        }
        return maxHeap.Dequeue();
    }
}

class CustomComparer : IComparer<int>
{
    public int Compare(int x, int y)
    {
        return y.CompareTo(x);
    }
}


/*
 0  1  2  3
 4  5  6  7
 8  9 10 11
12 13 14 15
*/