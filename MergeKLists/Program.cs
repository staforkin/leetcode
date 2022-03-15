
var solution = new Solution();
var arr1 = new[] { 1, 4, 5 };
var head1 = new ListNode(arr1[0]);
if (arr1.Length > 1)
{
    CreateList(head1, arr1[1..]);
}
var arr2 = new[] { 1, 3, 4 };
var head2 = new ListNode(arr2[0]);
if (arr2.Length > 1)
{
    CreateList(head2, arr2[1..]);
}

//https://leetcode.com/problems/merge-k-sorted-lists/
var node = solution.MergeKLists(new[] { head1, head2 });
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
    public ListNode MergeKLists(ListNode[] lists)
    {
        if (lists == null || lists.Length == 0)
        {
            return null;
        }
        var q = new System.Collections.Generic.PriorityQueue<ListNode, int>(new ListNodeComparer());
        var head = new ListNode(0);
        var p = head;

        foreach (var list in lists)
        {
            if (list != null)
                q.Enqueue(list, list.val);
        }

        while (q.Count > 0)
        {
            var n = q.Dequeue();
            p.next = n;
            if (n.next != null)
            {
                q.Enqueue(n.next, n.next.val);
            }
            p = p.next;
        }

        return head.next;
    }
}

public class ListNodeComparer : IComparer<int>
{
    public int Compare(int x, int y)
    {
        return x - y;
    }
}
/**
 * Definition for singly-linked list.*/
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