using System;

namespace ReverseOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new[] { 1, 2, 8, 9, 12, 16 };
            Node head = BuildLinkedListFromArray(arr);
            var res = Reverse(head);
            while (res != null)
            {
                Console.Write(res.data + " ");
                res = res.next;
            }
        }

        private static Node BuildLinkedListFromArray(int[] arr)
        {
            Node head = null;
            Node tempHead = head;
            foreach (var item in arr)
            {
                if (head == null)
                {
                    head = new Node(item);
                    tempHead = head;
                }
                else
                {
                    head.next = new Node(item);
                    head = head.next;
                }
            }
            return tempHead;
        }

        private static Node Reverse(Node head)
        {
            return reverse(head, null);
        }

        static Node reverse(Node head, Node prev)
        {
            // Base case
            if (head == null)
                return null;

            Node temp;
            Node curr;
            curr = head;

            // Reversing nodes until curr node's value
            // turn odd or Linked list is fully traversed
            while (curr != null && curr.data % 2 == 0)
            {
                temp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = temp;
            }

            // If elements were reversed then head
            // pointer needs to be changed
            if (curr != head)
            {
                head.next = curr;

                // Recur for the remaining linked list
                curr = reverse(curr, null);
                return prev;
            }

            // Simply iterate over the odd value nodes
            else
            {
                head.next = reverse(head.next, head);
                return head;
            }
        }
        private static bool IsEven(int? x)
        {
            if (x.HasValue)
            {
                return x % 2 == 0;
            }
            return false;
        }
    }
    class Node
    {
        public int data;
        public Node next;
        public Node(int x)
        {
            data = x;
            next = null;
        }
    }
}
