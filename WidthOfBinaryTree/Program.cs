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