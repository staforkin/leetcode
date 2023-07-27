var solution = new Solution();
var root = new TreeNode(1);
root.right = new TreeNode(2);
root.right.left = new TreeNode(2);
Console.WriteLine(string.Join(",", solution.FindMode(root)));

// https://leetcode.com/problems/find-mode-in-binary-search-tree
public class Solution
{
    public int[] FindMode(TreeNode root)
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