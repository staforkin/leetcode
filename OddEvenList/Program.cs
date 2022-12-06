var solution = new Solution();
// 1 2 3 4 5
var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
var newHead = solution.OddEvenList(head);
while(newHead!=null){
    
}

// https://leetcode.com/problems/odd-even-linked-list
public class Solution
{
    public ListNode OddEvenList(ListNode head)
    {
        if (head != null)
        {
            // odd 1 3 5
            // even 2 4
            ListNode odd = head, even = head.next, evenHead = even; //save even head
            while (even != null && even.next != null)
            {
                odd.next = odd.next.next;
                even.next = even.next.next;
                odd = odd.next;
                even = even.next;
            }
            odd.next = evenHead;
        }

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