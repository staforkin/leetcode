var solution = new Solution();
var head = new ListNode(1);
head.next = new ListNode(2);
head.next.next = new ListNode(6);
head.next.next.next = new ListNode(3);
head.next.next.next.next = new ListNode(4);
head.next.next.next.next.next = new ListNode(5);
head.next.next.next.next.next.next = new ListNode(6);
var head2 = new ListNode(6);
head2.next = new ListNode(6);
var newHead = solution.RemoveElements(head2, 6);
while (newHead != null)
{
    Console.WriteLine(newHead.val);
    newHead = newHead.next;
}

// https://leetcode.com/problems/remove-linked-list-elements
public class Solution
{
    public ListNode RemoveElements(ListNode head, int val)
    {
        if (head == null)
        {
            return null;
        }
        head.next = RemoveElements(head.next, val);
        return head.val == val ? head.next : head;
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