var solution = new Solution();
var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4))));
var newHead = solution.SwapPairs(head);

while (newHead != null)
{
    Console.WriteLine(newHead.val);
    newHead = newHead.next;
}

// https://leetcode.com/problems/swap-nodes-in-pairs/
public class Solution
{
    public ListNode SwapPairs(ListNode head)
    {
        // 1 - 2 - 3 - 4
        if (head == null || head.next == null)
        {
            return head;
        } //If there are less than 2 nodes in the given nodes, then no need to do anything just return the list as it is.

        ListNode dummyNode = new ListNode();

        ListNode prevNode = dummyNode;
        ListNode currNode = head;

        while (currNode != null && currNode.next != null)
        {
            prevNode.next = currNode.next;
            currNode.next = prevNode.next.next;
            prevNode.next.next = currNode;

            prevNode = currNode;
            currNode = currNode.next;
        }

        return dummyNode.next;
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