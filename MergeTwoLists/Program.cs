var solution = new Solution();
var arr1 = new[] { 5 };
var head1 = new ListNode(arr1[0]);
if (arr1.Length > 1)
{
    CreateList(head1, arr1[1..]);
}
var arr2 = new[] { 2, 3, 4 };
var head2 = new ListNode(arr2[0]);
if (arr2.Length > 1)
{
    CreateList(head2, arr2[1..]);
}

//https://leetcode.com/problems/merge-two-sorted-lists/
var node = solution.MergeTwoLists(head1, head2);
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
    // 1-2-4-5-6
    // 2-3-4
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode head = new ListNode(0);
        var res = head;
        while (list1 != null || list2 != null)
        {
            if (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
                {
                    head.next = new ListNode(list1.val);
                    list1 = list1.next;
                } else {
                    head.next = new ListNode(list2.val);
                    list2 = list2.next;
                }
                head = head.next;
            }
            else if (list1 == null)
            {
                head.next = new ListNode(list2.val);
                head = head.next;
                list2 = list2.next;
            }
            else if (list2 == null)
            {
                head.next = new ListNode(list1.val);
                head = head.next;
                list1 = list1.next;
            }
        }
        return res.next;
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
