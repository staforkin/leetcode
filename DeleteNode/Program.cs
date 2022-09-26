//  Definition for singly-linked list.

var solution = new Solution();
var list = new ListNode(4);
list.next = new ListNode(5);
list.next.next = new ListNode(1);
list.next.next.next = new ListNode(9);
solution.DeleteNode(list.next);
var t = list;

while(t!=null){
    Console.WriteLine(t.val);
    t = t.next;
}

//https://leetcode.com/problems/delete-node-in-a-linked-list/
public class Solution
{
    public void DeleteNode(ListNode node)
    {
        node.val = node.next.val;
        node.next = node.next.next; 
    }
}

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }
}