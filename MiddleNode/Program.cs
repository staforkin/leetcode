
// https://leetcode.com/problems/middle-of-the-linked-list
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
public class Solution
{
    public ListNode MiddleNode(ListNode head)
    {
        // 1 - 2 - 3 - 4 - 5
        // s - s
        // f - - - f
        //.    s - s
        //.        f - - - f
        var slow = head;
        var fast = head;
        while (fast != null)
        {
            if (fast.next == null)
            {
                return slow;
            }
            slow = slow.next;
            fast = fast.next.next;
        }
        return slow;
    }
}