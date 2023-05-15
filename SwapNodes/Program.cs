var solution = new Solution();
var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
var newHead = solution.SwapNodes(head, 2);
while (newHead != null)
{
    Console.Write(newHead.val);
    newHead = newHead.next;
}

// https://leetcode.com/problems/swapping-nodes-in-a-linked-list
public class Solution
{
    public ListNode SwapNodes(ListNode head, int k)
    {
        // 1 - 2 - 3 - 4 - 5

        ListNode n1 = null, n2 = null;
        for (var p = head; p != null; p = p.next)
        {
            n2 = n2 == null ? null : n2.next;
            if (--k == 0)
            {
                n1 = p;
                n2 = head;
            }
        } 
        var tmp = n1.val;
        n1.val = n2.val;
        n2.val = tmp;
        return head;
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
