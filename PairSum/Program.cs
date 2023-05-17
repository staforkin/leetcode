var solution = new Solution();
var head = new ListNode(5, new ListNode(4, new ListNode(2, new ListNode(1))));
Console.WriteLine(solution.PairSum(head));


// https://leetcode.com/problems/maximum-twin-sum-of-a-linked-list
public class Solution
{
    ListNode ptr = null;
    int maxSum = 0;
    public int PairSum(ListNode head)
    {
        ptr = head;
        maxSum = 0;
        compute(head);
        return maxSum;
    }
    private void compute(ListNode head)
    {
        if (head == null)
        {
            return;
        }
        compute(head.next);
        maxSum = Math.Max(maxSum, head.val + ptr.val);
        ptr = ptr.next;
    }
}


public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}