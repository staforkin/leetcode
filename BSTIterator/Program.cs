using System;
using System.Collections.Generic;

namespace BSTIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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

    public class BSTIterator
    {
        List<int> nodesSorted;
        int index;
        public BSTIterator(TreeNode root)
        {
            // Array containing all the nodes in the sorted order
            this.nodesSorted = new List<int>();

            // Pointer to the next smallest element in the BST
            this.index = -1;

            // Call to flatten the input binary search tree
            this._inorder(root);

        }

        private void _inorder(TreeNode root)
        {

            if (root == null)
            {
                return;
            }

            this._inorder(root.left);
            this.nodesSorted.Add(root.val);
            this._inorder(root.right);
        }

        public int Next()
        {
            return this.nodesSorted[++this.index];
        }

        public bool HasNext()
        {
            return this.index + 1 < this.nodesSorted.Count;
        }
    }
}
