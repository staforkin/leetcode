var solution = new Solution();
Console.WriteLine(solution.MaxScore(new[] { 2, 1, 14, 12 }, new[] { 11, 7, 13, 6 }, 3));

// https://leetcode.com/problems/maximum-subsequence-score
public class Solution
{
    public long MaxScore(int[] nums1, int[] nums2, int k)
    {
        int n = nums1.Length;
        int[][] ess = new int[n][];
        for (int i = 0; i < n; ++i)
        {
            ess[i] = new int[] { nums2[i], nums1[i] };
        }
        Array.Sort(ess, Comparer<int[]>.Create((a, b) => b[0] - a[0]));
        var pq = new PriorityQueue<int, int>(k, Comparer<int>.Create((a, b) => a - b));
        long res = 0, sumS = 0;
        foreach (int[] es in ess)
        {
            pq.Enqueue(es[1], es[1]);
            sumS = (sumS + es[1]);
            if (pq.Count > k)
            {
                sumS -= pq.Dequeue();
            }
            if (pq.Count == k)
            {
                res = Math.Max(res, (sumS * es[0]));
            }
        }
        return res;
    }
}