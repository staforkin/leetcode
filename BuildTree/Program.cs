var solution = new Solution();
var preOrder = new[] { 3, 9, 20, 15, 7 };
var inOrder = new[] { 9, 3, 15, 20, 7 };

solution.BuildTree(preOrder, inOrder);

//https://leetcode.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal
public class Solution
{
    public TreeNode BuildTree(int[] preorder, int[] inorder)
    {
        return helper(0, 0, inorder.Length - 1, preorder, inorder);
    }
    public TreeNode helper(int preStart, int inStart, int inEnd, int[] preorder, int[] inorder)
    {
        if (preStart > preorder.Length - 1 || inStart > inEnd)
        {
            return null;
        }
        TreeNode root = new TreeNode(preorder[preStart]);
        int inIndex = 0; // Index of current root in inorder
        for (int i = inStart; i <= inEnd; i++)
        {
            if (inorder[i] == root.val)
            {
                inIndex = i;
            }
        }
        root.left = helper(preStart + 1,                        inStart,     inIndex - 1, preorder, inorder);//left side of the root
        root.right = helper(preStart + inIndex - inStart + 1, inIndex + 1, inEnd,       preorder, inorder);//right side of the root
        return root;
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