using System;
using System.Collections.Generic;

namespace RightSideView
{
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
    class Program
    {
        static void Main(string[] args)
        {
            var root = buildTree(new List<int?>() { 1, 2, 3, null, 5, null, 4 });
            var result = RightSideViewImpl(root);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        public static IList<int> RightSideViewImpl(TreeNode root)
        {
            // level: 0, Elements: root
            // Level: 1, Elements: 2, 3
            // etc

        }

        private static Dictionary<int, int> BreadthFirst(TreeNode node)
        {
            if (node == null)
            { return null; }
            
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
}
