var solution = new Solution();
var head = new ListNode(3);
head.next = new ListNode(2);

head.next.next = new ListNode(0);
head.next.next.next = new ListNode(-4);
head.next.next.next.next = head.next.next;
Console.WriteLine(solution.HasCycle(null));

//https://leetcode.com/problems/linked-list-cycle/
public class Solution
{
    public bool HasCycle(ListNode head)
    {
        if (head == null) return false;
        ListNode walker = head;
        ListNode runner = head;
        while (runner.next != null && runner.next.next != null)
        {
            walker = walker.next;
            runner = runner.next.next;
            if (walker == runner) return true;
        }
        return false;
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