var solution = new Solution();
var preOrder = new []{3,9,20,15,7};
var inOrder = new []{9,3,15,20,7};

//https://leetcode.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal
public class Solution
{
    public TreeNode BuildTree(int[] preorder, int[] inorder)
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