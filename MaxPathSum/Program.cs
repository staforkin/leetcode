using System;
using System.Collections.Generic;
using System.Text;

namespace MaxPathSum
{
    public class Program
    {
        public static int MaxSum = int.MinValue;
        static void Main(string[] args)
        {
            var input = new List<int?>() { 0 };
            var root = buildTree(input);
            Console.WriteLine(MaxPathSumImpl(root));

        }
        public static int MaxPathSumImpl(TreeNode root)
        {
            MaxGain(root);
            return MaxSum;
        }

        public static int MaxGain(TreeNode node){
            if(node == null) return 0;

            int leftGain = Math.Max(MaxGain(node.left),0);
            int rightGain = Math.Max(MaxGain(node.right),0);

            int priceNewPath = node.val + leftGain + rightGain;

            MaxSum = Math.Max(MaxSum, priceNewPath);

            return node.val + Math.Max(leftGain, rightGain);
        }

        public static TreeNode buildTree(List<int?> arr)
        {
            TreeNode root = null;
            Queue<TreeNode> q = new Queue<TreeNode>();
            int i = 0;
            TreeNode t = arr[i] == null ? null : new TreeNode(arr[i].Value);
            root = t;
            q.Enqueue(root);
            i++;
            while (q.Count != 0 && i < arr.Count)
            {
                TreeNode t1 = q.Dequeue();
                if (t1 != null)
                {
                    t1.left = arr[i] == null ? null : new TreeNode(arr[i].Value);
                    q.Enqueue(t1.left);
                    i++;
                    if (i >= arr.Count)
                    {
                        break;
                    }
                    t1.right = arr[i] == null ? null : new TreeNode(arr[i].Value);
                    q.Enqueue(t1.right);
                    i++;
                }
            }
            printLevelOrder(root);
            return root;
        }
        private static void printLevelOrder(TreeNode root)
        {
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            StringBuilder sb = new StringBuilder();
            while (q.Count != 0)
            {
                TreeNode t = q.Dequeue();
                sb.Append(t == null ? "null" : t.val).Append(", ");
                if (t != null)
                {
                    q.Enqueue(t.left);
                    q.Enqueue(t.right);
                }
            }
            Console.WriteLine(sb.ToString());
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
