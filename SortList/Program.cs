var solution = new Solution();
var head = new ListNode(3);
head.next = new ListNode(1);
head.next.next = new ListNode(2);
head.next.next.next = new ListNode(4);
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
        if (head == null || head.next == null)
        {
            return head;
        }

        ListNode prev = null, slow = head, fast = head;

        while (fast != null && fast.next != null)
        {
            prev = slow;
            slow = slow.next;
            fast = fast.next.next;
        }

        prev.next = null;

        // step 2. sort each half
        ListNode l1 = SortList(head);
        ListNode l2 = SortList(slow);

        // step 3. merge l1 and l2
        return merge(l1, l2);
    }

    private ListNode merge(ListNode l1, ListNode l2)
    {
        ListNode l = new ListNode(0), p = l;

        while (l1 != null && l2 != null)
        {
            if (l1.val < l2.val)
            {
                p.next = l1;
                l1 = l1.next;
            }
            else
            {
                p.next = l2;
                l2 = l2.next;
            }
            p = p.next;
        }

        if (l1 != null)
        { p.next = l1; }

        if (l2 != null)
        { p.next = l2; }

        return l.next;
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