var solution = new Solution();
var head = new ListNode(5, new ListNode(4, new ListNode(2, new ListNode(1))));
Console.WriteLine(solution.PairSum(head));


// https://leetcode.com/problems/maximum-twin-sum-of-a-linked-list
public class Solution
{
    public int PairSum(ListNode head)
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