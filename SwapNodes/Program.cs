var solution = new Solution();
var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
var newHead = solution.SwapNodes(head, 2);

// https://leetcode.com/problems/swapping-nodes-in-a-linked-list
public class Solution
{
    public ListNode SwapNodes(ListNode head, int k)
    {

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
