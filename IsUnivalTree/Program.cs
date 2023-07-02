var solution = new Solution();
var root = new TreeNode(1);
root.left = new TreeNode(1);
root.right = new TreeNode(1);
Console.WriteLine(solution.IsUnivalTree(root));

// https://leetcode.com/problems/univalued-binary-tree
public class Solution
{
    public bool IsUnivalTree(TreeNode root)
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