var solution = new KthLargest(3, new []{4,5,8,2});
Console.WriteLine(solution.Add(3));
Console.WriteLine(solution.Add(5));
Console.WriteLine(solution.Add(10));
Console.WriteLine(solution.Add(9));
Console.WriteLine(solution.Add(4));

// https://leetcode.com/problems/kth-largest-element-in-a-stream
public class KthLargest {

    private PriorityQueue<int,int> q;
    private int k;

    public KthLargest(int k, int[] nums) {
        this.k = k;
        q = new PriorityQueue<int,int>(k);
        foreach (var n in nums)
        {
            Add(n);
        }
    }
    
    public int Add(int val) {
        if(q.Count < k){
            q.Enqueue(val,val);
        } else if (q.Peek()<val){
            q.Dequeue();
            q.Enqueue(val,val);
        }
        return q.Peek();
    }
}