var solution = new Solution();
var head = new ListNode(3);
head.next = new ListNode(2);
head.next.next = new ListNode(0);
head.next.next.next = new ListNode(-4);
head.next.next.next.next = head.next;
Console.WriteLine(solution.DetectCycle(head)?.val);

// https://leetcode.com/problems/linked-list-cycle-ii
public class Solution
{
    public ListNode DetectCycle(ListNode head)
    {

    }
}

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int x)
    {
        val = x;
        next = null;
    }
}