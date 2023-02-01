var solution = new Solution();
var root = new TreeNode(3);
root.left = new TreeNode(9);
root.right = new TreeNode(20);
root.right.left = new TreeNode(15);
root.right.right = new TreeNode(7);
Console.WriteLine(solution.MinDepth(root));

// https://leetcode.com/problems/minimum-depth-of-binary-tree
public class Solution
{
    public int MinDepth(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }
        var left = MinDepth(root.left);
        var right = MinDepth(root.right);
        return (left == 0 || right == 0) ? left + right + 1 : Math.Min(left, right) + 1;
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