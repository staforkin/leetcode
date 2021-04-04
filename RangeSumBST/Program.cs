using System;

namespace RangeSumBST
{
    class Program
    {
        private static int Sum = 0;
        static void Main(string[] args)
        {
            Sum = 0;
            Console.WriteLine("Hello World!");
        }

        public static int RangeSumBSTImpl(TreeNode root, int low, int high)
        {
            Helper(root, low, high);
            return Sum;
        }
        public static void Helper(TreeNode node, int low, int high)
        {
            if (node == null)
                return;
            if (node.val >= low && node.val <= high)
            {
                Sum += node.val;
            }
            if (node.val > low)
            {
                Helper(node.left, low, high);
            }
            if (node.val < high)
            {
                Helper(node.right, low, high);
            }
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
}
