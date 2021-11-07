using System;

namespace GoodNodes
{
    class Program
    {
        //https://leetcode.com/problems/count-good-nodes-in-binary-tree/
        static void Main(string[] args)
        {
            //          3
            //      1           4
            //3     null       1       5
            var nodes = new int?[] { 3, 1, 4, 3, null, 1, 5 };
            var root = new TreeNode(nodes, 0);
            Console.WriteLine(GoodNodes(root));
        }

        public static int GoodNodes(TreeNode root)
        {
            return goodNodes(root, -10000);
        }

        public static int goodNodes(TreeNode root, int ma)
        {
            if (root == null) return 0;
            int res = root.val >= ma ? 1 : 0;
            res += goodNodes(root.left, Math.Max(ma, root.val));
            res += goodNodes(root.right, Math.Max(ma, root.val));
            return res;
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
        public TreeNode(int?[] values, int index)
        {
            BuildTree(this, values, index);
        }
        private void BuildTree(TreeNode node, int?[] values, int index)
        {
            this.val = values[index].Value;
            if (index * 2 + 1 < values.Length && values[index * 2 + 1].HasValue)
            {
                this.left = new TreeNode(values, index * 2 + 1);
            }
            if (index * 2 + 2 < values.Length && values[index * 2 + 2].HasValue)
            {
                this.right = new TreeNode(values, index * 2 + 2);
            }
        }
    }
}
