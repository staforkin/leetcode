var solution = new Solution();
var head = new ListNode(1);
head.next = new ListNode(2);
head.next.next = new ListNode(3);
head.next.next.next = new ListNode(4);
head.next.next.next.next = new ListNode(5);
var newHead = solution.RotateRight(head, 2);
while (newHead != null)
{
    Console.WriteLine(newHead.val);
    newHead = newHead.next;
}

// https://leetcode.com/problems/rotate-list
public class Solution
{
    public ListNode RotateRight(ListNode head, int k)
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