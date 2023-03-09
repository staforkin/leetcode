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
        ListNode slow = head, fast = head;
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
            if (slow == fast) break;
        }
        if (fast == null || fast.next == null)
        {
            return null;
        }
        while (head != slow)
        {
            head = head.next;
            slow = slow.next;
        }
        return head;
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