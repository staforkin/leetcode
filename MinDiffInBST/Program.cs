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
    int res = int.MaxValue;
    int? pre = null;
    public int MinDiffInBST(TreeNode root)
    {
        if (root.left != null)
        {
            MinDiffInBST(root.left);
        }
        if (pre.HasValue)
        {
            res = Math.Min(res, root.val - pre.Value);
        }
        pre = root.val;
        if (root.right != null)
        {
            MinDiffInBST(root.right);
        }
        return res;
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