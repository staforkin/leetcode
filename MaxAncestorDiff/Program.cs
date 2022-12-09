var solution = new Solution();
var root = new TreeNode(1);
root.right = new TreeNode(2);
root.right.right = new TreeNode(0);
root.right.right.right = new TreeNode(3);
Console.WriteLine(solution.MaxAncestorDiff(root));

// https://leetcode.com/problems/maximum-difference-between-node-and-ancestor
public class Solution
{
    public int MaxAncestorDiff(TreeNode root)
    {
        return dfs(root, root.val, root.val);
    }
    public int dfs(TreeNode root, int min, int max)
    {
        if (root == null) {
            return max - min;
        }
        max = Math.Max(max, root.val);
        min = Math.Min(min, root.val);
        return Math.Max(dfs(root.left, min, max), dfs(root.right, min, max));
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