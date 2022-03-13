using System;

namespace AddTwoNumbers
{

    //Definition for singly-linked list.
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

    class Program
    {
        //https://leetcode.com/problems/add-two-numbers/
        static void Main(string[] args)
        {
            var l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
            var l2 = new ListNode(5, new ListNode(6, new ListNode(4)));
            var solution = new Solution();
            ListNode l3 = solution.AddTwoNumbers(l1, l2);
            var p = l3;
            do
            {
                Console.Write(p.val);
                p = p.next;
            } while (p != null);
        }
    }

    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var result = new ListNode(0);
            ListNode resultCurrentNode = result;
            var t1 = l1;
            var t2 = l2;
            int carry = 0;
            while (t1 != null || t2 != null)
            {
                int t = (t1 != null ? t1.val : 0) + (t2 != null ? t2.val : 0) + carry;
                carry = t / 10;
                resultCurrentNode.next = new ListNode(t % 10);
                resultCurrentNode = resultCurrentNode.next;
                if (t1 != null) t1 = t1.next;
                if (t2 != null) t2 = t2.next;
            }
            if (carry > 0)
            {
                resultCurrentNode.next = new ListNode(carry);
            }
            return result.next;
        }
    }
}
