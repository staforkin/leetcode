using System;

namespace ReorderList
{
    // Definition for singly-linked list.
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
    public class Program
    {
        static void Main(string[] args)
        {
            var list = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
            //1-2-3-4 -> 1-4-2-3

            //0-1-2-3-4 -> 
            //1-2-3-4-5 -> 1-5-2-4-3
            //1-5-2-3-4
            //1-5-2-4-3

            ReorderList(list);
            while (list != null)
            {
                Console.Write(list.val);
                list = list.next;
            }
        }

        private static void ReorderList(ListNode head)
        {
            if (head == null) return;

            // find the middle of linked list [Problem 876]
            // in 1->2->3->4->5->6 find 4 
            ListNode slow = head, fast = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            // reverse the second part of the list [Problem 206]
            // convert 1->2->3->4->5->6 into 1->2->3->4 and 6->5->4
            // reverse the second half in-place
            ListNode prev = null, curr = slow, tmp;
            while (curr != null)
            {
                tmp = curr.next;

                curr.next = prev;
                prev = curr;
                curr = tmp;
            }

            // merge two sorted linked lists [Problem 21]
            // merge 1->2->3->4 and 6->5->4 into 1->6->2->5->3->4
            ListNode first = head, second = prev;
            while (second.next != null)
            {
                tmp = first.next;
                first.next = second;
                first = tmp;

                tmp = second.next;
                second.next = first;
                second = tmp;
            }
        }
    }
}