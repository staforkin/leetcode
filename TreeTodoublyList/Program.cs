using System;

namespace TreeTodoublyList
{
    class Program
    {
        static Node first = null;
        static Node last = null;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static Node TreeToDoublyListImpl(Node root)
        {
            first = null;
            last = null;
            if (root == null)
                return null;
            Helper(root);
            last.right = first;
            first.left = last;
            return first;
        }

        private static void Helper(Node node)
        {
            if (node != null)
            {
                //left
                Helper(node.left);
                if (last != null)
                {
                    last.right = node;
                    node.left = last;
                }
                else
                {
                    first = node;
                }
                last = node;
                Helper(node.right);
            }
        }
    }
    public class Node
    {
        public int val;
        public Node left;
        public Node right;
        public Node() { }
        public Node(int _val)
        {
            val = _val;
            left = null;
            right = null;
        }
        public Node(int _val, Node _left, Node _right)
        {
            val = _val;
            left = _left;
            right = _right;
        }
    }
}
