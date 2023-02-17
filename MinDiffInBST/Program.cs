var solution = new Solution();
var root = new TreeNode(4);
root.right = new TreeNode(6);
root.left = new TreeNode(2);
root.left.left = new TreeNode(1);
root.left.right = new TreeNode(3);
Console.WriteLine(solution.MinDiffInBST(root));

// https://leetcode.com/problems/minimum-distance-between-bst-nodes
public class Solution
{
    public int MinDiffInBST(TreeNode root)
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