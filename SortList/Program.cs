var solution = new Solution();
var head = new ListNode(3);
head.next = new ListNode(1);
head.next.next = new ListNode(2);
var sorted = solution.SortList(head);

var t = sorted;
while (t != null)
{
    Console.WriteLine(t.val);
    t = t.next;
}

// https://leetcode.com/problems/sort-list
public class Solution
{
    public ListNode SortList(ListNode head)
    {
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