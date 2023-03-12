var solution = new Solution();
var head = new ListNode(1);
head.next = new ListNode(2);
head.next.next = new ListNode(3);
head.next.next.next = new ListNode(4);
head.next.next.next.next = new ListNode(5);
var newHead = solution.RotateRight(head, 2);
while (newHead != null)
{
    Console.WriteLine(newHead.val);
    newHead = newHead.next;
}

// https://leetcode.com/problems/rotate-list
public class Solution
{
    public ListNode RotateRight(ListNode head, int k)
    {
        // 1-2-3|4-5

        // 4-5-1-2-3

        if (head == null || head.next == null)
        {
            return head;
        }
        var dummy = new ListNode(0);
        dummy.next = head;
        var fast = dummy;
        var slow = dummy;

        int i;
        for (i = 0; fast.next != null; i++)//Get the total length 
        {
            fast = fast.next;
        }

        for (int j=i-k%i;j>0;j--) //Get the i-n%i th node
    	{
            slow=slow.next;
        }

        fast.next=dummy.next; //Do the rotation
        dummy.next=slow.next;
        slow.next=null;
        
        return dummy.next;
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