var solution = new Solution();
var head = solution.ReverseList(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, null))))));
var t = head;
while(t!=null){
    Console.Write(t.val);
    t = t.next;
}

// https://leetcode.com/problems/reverse-linked-list
public class Solution
{
    public ListNode ReverseList(ListNode head)
    {
        ListNode newHead = null;
        while(head!=null){
            ListNode next = head.next;
            head.next = newHead;
            newHead = head;
            head = next;
        }
        return newHead;
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