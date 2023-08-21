var solution = new Solution();
var root = new TreeNode(5);
root.left = new TreeNode(3);
root.left.left = new TreeNode(2);
root.left.right = new TreeNode(4);
root.left.left.left = new TreeNode(1);
root.right = new TreeNode(6);
root.right.right = new TreeNode(8);
root.right.right.left = new TreeNode(7);
root.right.right.right = new TreeNode(9);
var newRoot = solution.IncreasingBST(root);
while (newRoot is not null)
{
    Console.Write(newRoot.val + " ");
    newRoot = newRoot.right;
}

// https://leetcode.com/problems/increasing-order-search-tree
public class Solution
{
    public TreeNode IncreasingBST(TreeNode root)
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