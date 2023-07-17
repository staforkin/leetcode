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
        var s1 = new Stack<int>();
        var s2 = new Stack<int>();

        while (l1 != null)
        {
            s1.Push(l1.val);
            l1 = l1.next;
        };
        while (l2 != null)
        {
            s2.Push(l2.val);
            l2 = l2.next;
        }

        int sum = 0;
        ListNode list = new ListNode(0);
        while (s1.Any() || s2.Any())
        {
            if (s1.Any())
            {
                sum += s1.Pop();
            }
            if (s2.Any())
            {
                sum += s2.Pop();
            }
            list.val = sum % 10;
            ListNode head = new ListNode(sum / 10);
            head.next = list;
            list = head;
            sum /= 10;
        }

        return list.val == 0 ? list.next : list;
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