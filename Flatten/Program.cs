var solution = new Solution();
var root = new TreeNode(1);
root.left = new TreeNode(2);
root.left.left = new TreeNode(3);
root.left.right = new TreeNode(4);
root.right = new TreeNode(5);
root.right.right = new TreeNode(6);
solution.Flatten(root);
var t = root;
while (t != null)
{
    Console.WriteLine(t.val);
    t = t.right;
}

// https://leetcode.com/problems/flatten-binary-tree-to-linked-list
public class Solution
{
    public void Flatten(TreeNode root)
    {
        if (root == null)
        {
            return;
        }

        TreeNode left = root.left;
        TreeNode right = root.right;

        root.left = null;

        Flatten(left);
        Flatten(right);

        root.right = left;
        TreeNode cur = root;
        while (cur.right != null)
        {
            cur = cur.right;
        }
        cur.right = right;
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