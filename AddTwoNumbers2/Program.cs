var solution = new Solution();
var head1 = new ListNode(7, new ListNode(2, new ListNode(4, new ListNode(3))));
var head2 = new ListNode(5, new ListNode(6, new ListNode(4)));
var res = solution.AddTwoNumbers(head1, head2);
while (res != null)
{
    Console.Write(res.val);
    res = res.next;
}

// https://leetcode.com/problems/add-two-numbers-ii
public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
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