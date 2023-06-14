var solution = new Solution();
var root = new TreeNode(4);
root.right = new TreeNode(6);
root.left = new TreeNode(2);
root.left.left = new TreeNode(1);
root.left.right = new TreeNode(2);
Console.WriteLine(solution.GetMinimumDifference(root));

// https://leetcode.com/problems/minimum-absolute-difference-in-bst
public class Solution
{
    public int GetMinimumDifference(TreeNode root)
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