
var solution = new Solution();
var headA = new ListNode(4);
var headB = new ListNode(5);
headB.next = new ListNode(6);
var one = new ListNode(99);
headA.next = one;
headB.next.next = one;

var node = solution.GetIntersectionNode(headA, headB);
Console.WriteLine(node?.val);

// https://leetcode.com/problems/intersection-of-two-linked-lists
public class Solution
{
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        //   4 1 = length 2
        // 5 6 1 = length 3
        // start walking from head + mod(l2 - l1)
        var lengthA = GetLength(headA);
        var lengthB = GetLength(headB);
        var diff = Math.Abs(lengthB - lengthA);
        var newA = lengthB > lengthA ? headB : headA;//longer
        var newB = lengthB > lengthA ? headA : headB;//shorter
        while (diff > 0)
        {
            newA = newA.next;
            diff--;
        }
        while (newA != null && newB != null)
        {
            if (newA == newB)
            {
                return newA;
            }
            newA = newA.next;
            newB = newB.next;
        }
        return null;
    }

    private int GetLength(ListNode head)
    {
        int res = default;
        while (head != null)
        {
            head = head.next;
            res++;
        }
        return res;
    }
}

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }
}