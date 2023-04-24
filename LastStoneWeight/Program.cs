var solution = new Solution();
Console.WriteLine(solution.LastStoneWeight(new int[] { 2, 7, 4, 1, 8, 1 }));

// https://leetcode.com/problems/last-stone-weight
public class Solution
{
    public int LastStoneWeight(int[] stones)
    {
        var pq = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b - a));
        foreach (int a in stones)
        {
            pq.Enqueue(a, a);
        }
        while (pq.Count > 1)
        {
            var t = pq.Dequeue() - pq.Dequeue();
            pq.Enqueue(t, t);
        }
        return pq.Dequeue();
    }
}