﻿var solution = new Solution();
var head = new ListNode(-10);
head.next = new ListNode(-3);
head.next.next = new ListNode(0);
head.next.next.next = new ListNode(5);
head.next.next.next.next = new ListNode(9);
var root = solution.SortedListToBST(head);

// https://leetcode.com/problems/convert-sorted-list-to-binary-search-tree
public class Solution
{
    private ListNode _head;
    public TreeNode SortedListToBST(ListNode head)
    {
        if (head == null)
        {
            return null;
        }
        return ToBST(head, null);
    }

    private TreeNode ToBST(ListNode head, ListNode tail)
    {
        ListNode slow = head;
        ListNode fast = head;
        if (head == tail)
        {
            return null;
        }
        while (fast != tail && fast.next != tail)
        {
            fast = fast.next.next;
            slow = slow.next;
        }
        TreeNode thead = new TreeNode(slow.val);
        thead.left = ToBST(head, slow);
        thead.right = ToBST(slow.next, tail);
        return thead;
    }
}

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
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