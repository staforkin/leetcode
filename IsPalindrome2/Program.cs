var solution = new Solution();
var head = new ListNode(1, new ListNode(2, new ListNode(2, new ListNode(3))));
Console.WriteLine(solution.IsPalindrome(head));

// https://leetcode.com/problems/palindrome-linked-list
public class Solution
{
    public bool IsPalindrome(ListNode head)
    {
        var array = new List<int>();
        var t = head;
        while(t!=null){
            array.Add(t.val);
            t = t.next;
        }
        // 1 2 3 2 1    L = 5
        for(int i = 0; i<array.Count/2;i++){
            if(array[i]!=array[array.Count-1-i]){
                return false;
            }
        }
        return true;
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