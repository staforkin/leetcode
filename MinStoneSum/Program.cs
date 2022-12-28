var solution = new Solution();
Console.WriteLine(solution.MinStoneSum(new[] { 5, 4, 9 }, 2));

// https://leetcode.com/problems/remove-stones-to-minimize-the-total/
public class Solution
{
    public int MinStoneSum(int[] piles, int k)
    {
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b - a));
        int res = 0;
        foreach (int a in piles)
        {
            pq.Enqueue(a, a);
            res += a;
        }
        while (k-- > 0)
        {
            int a = pq.Dequeue();
            pq.Enqueue(a - a / 2, a - a / 2);
            res -= a / 2;
        }
        return res;
    }
}