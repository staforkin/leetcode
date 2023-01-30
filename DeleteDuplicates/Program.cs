var solution = new Solution();
var head = new ListNode(1);
head.next = new ListNode(2);
head.next.next = new ListNode(1);
var newHead = solution.DeleteDuplicates(head);
var t = newHead;
while (t != null)
{
    Console.Write($"{t} ");
}

// https://leetcode.com/problems/remove-duplicates-from-sorted-list
public class Solution
{
    public ListNode DeleteDuplicates(ListNode head)
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