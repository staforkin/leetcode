var solution = new Solution();
Console.WriteLine(solution.LongestConsecutive(new[] { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 }));

// https://leetcode.com/problems/longest-consecutive-sequence/
public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        if (nums.Length == 0)
        {
            return 0;
        }
        var pq = new PriorityQueue<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            pq.Enqueue(nums[i], nums[i]);
        }

        var counts = new List<int>();
        counts.Add(1);
        var size = counts.Count - 1;
        var last = pq.Peek();
        for (int i = 0; i < nums.Length; i++)
        {
            var j = pq.Dequeue();
            if (j - last == 0)
            {
                continue;
            }
            if (j - last == 1)
            {
                counts[size]++;
            }
            else
            {
                counts.Add(1);
                size++;
            }
            last = j;
        }
        return counts.Max();
    }
}