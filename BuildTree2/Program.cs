var solution = new Solution();
var postorder = new[] { 9, 15, 7, 20, 3 };
var inOrder = new[] { 9, 3, 15, 20, 7 };

solution.BuildTree(inOrder, postorder);

// https://leetcode.com/problems/construct-binary-tree-from-inorder-and-postorder-traversal/
public class Solution
{
    public TreeNode BuildTree(int[] inorder, int[] postorder)
    {
        //           3
        //        20
        // 9 15 7 

        //  3    20
        // 9  15   7
        return helper(postorder.Length - 1, 0, inorder.Length - 1, inorder, postorder);
    }

    TreeNode helper(int ppos, int inStart, int inEnd, int[] inorder, int[] postorder)
    {
        if (ppos >= postorder.Length || inStart > inEnd)
        {
            return null;
        }
        TreeNode node = new TreeNode(postorder[ppos]);
        int postIndex = 0;
        for (int i = 0; i < inorder.Length; i++)
        {
            // get the index of root in inorder
            if (inorder[i] == postorder[ppos])
            {
                postIndex = i;
            }
        }
        node.left = helper(ppos - 1 - inEnd + postIndex, inStart, postIndex - 1, inorder, postorder);
        node.right = helper(ppos - 1, postIndex + 1, inEnd, inorder, postorder);
        return node;
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