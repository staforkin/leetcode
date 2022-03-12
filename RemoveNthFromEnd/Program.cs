var solution = new Solution();
var arr = new[] { 1, 2, 3, 4, 5 };
var head = new ListNode(arr[0]);
if (arr.Length > 1)
{
    CreateList(head, arr[1..]);
}

//https://leetcode.com/problems/remove-nth-node-from-end-of-list
var node = solution.RemoveNthFromEnd(head, 2);
while (node != null)
{
    Console.WriteLine(node.val);
    node = node.next;
}

static ListNode CreateList(ListNode node, int[] arr)
{
    node.next = new ListNode(arr[0]);
    if (arr.Length > 1)
    {
        return CreateList(node.next, arr[1..]);
    }
    return node.next;
}


public class Solution
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        ListNode start = new ListNode(0);
        start.next = head;
        ListNode slow = start, fast = start;

        for (int i = 1; i <= n + 1; i++)
        {
            fast = fast.next;
        }
        while (fast != null)
        {
            slow = slow.next;
            fast = fast.next;
        }

        slow.next = slow.next.next;
        return start.next;
    }
}

//Definition for singly-linked list.
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
