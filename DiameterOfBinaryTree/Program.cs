var solution = new Solution();
var root = new TreeNode(1);
root.left = new TreeNode(2);
root.right = new TreeNode(3);
root.left.left = new TreeNode(4);
root.left.right = new TreeNode(5);

// https://leetcode.com/problems/diameter-of-binary-tree/
public class Solution
{
    int max = 0;
    public int DiameterOfBinaryTree(TreeNode root)
    {
        maxDepth(root);
        return max;
    }

    private int maxDepth(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }

        int left = maxDepth(root.left);
        int right = maxDepth(root.right);

        max = Math.Max(max, left + right);

        return Math.Max(left, right) + 1;
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
