var solution = new Solution();

Console.WriteLine(solution.FindKthLargest(new[] { 3,2,1,6,5,4 }, 2));

// https://leetcode.com/problems/kth-largest-element-in-an-array
public class Solution
{
    public int FindKthLargest(int[] nums, int k)
    {
        var pq = new PriorityQueue<int,int>();
        foreach (var item in nums)
        {
            pq.Enqueue(item,item);

            if(pq.Count > k){
                pq.Dequeue();
            }
        }
        return pq.Peek();
    }
}