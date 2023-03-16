var solution = new Solution();
var postorder = new[] { 9, 15, 7, 20, 3 };
var inOrder = new[] { 9, 3, 15, 20, 7 };

solution.BuildTree(inOrder, postorder);

// https://leetcode.com/problems/construct-binary-tree-from-inorder-and-postorder-traversal/
public class Solution
{
    public TreeNode BuildTree(int[] inorder, int[] postorder)
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