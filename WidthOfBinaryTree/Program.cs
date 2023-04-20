var solution = new Solution();
var root = new TreeNode(1);
root.left = new TreeNode(3);
root.left.left = new TreeNode(5);
root.left.right = new TreeNode(3);
root.right = new TreeNode(2);
root.right.right = new TreeNode(9);
Console.WriteLine(solution.WidthOfBinaryTree(root));

// https://leetcode.com/problems/maximum-width-of-binary-tree
public class Solution
{
    public int WidthOfBinaryTree(TreeNode root)
    {
        if (root == null) return 0;
        var q = new Queue<TreeNode>();
        var m = new Dictionary<TreeNode, int>();
        q.Enqueue(root);
        m.Add(root, 1);
        int curW = 0;
        int maxW = 0;
        while (q.Any())
        {
            int size = q.Count;
            int start = 0;
            int end = 0;
            for (int i = 0; i < size; i++)
            {
                TreeNode node = q.Dequeue();
                if (i == 0)
                {
                    start = m[node];
                }
                if (i == size - 1)
                {
                    end = m[node];
                }
                if (node.left != null)
                {
                    m.TryAdd(node.left, m[node] * 2);
                    q.Enqueue(node.left);
                }
                if (node.right != null)
                {
                    m.TryAdd(node.right, m[node] * 2 + 1);
                    q.Enqueue(node.right);
                }
            }
            curW = end - start + 1;
            maxW = Math.Max(curW, maxW);
        }
        return maxW;
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