var solution = new Solution();
var root = new TreeNode(1);
root.left = new TreeNode(2);
root.left.left = new TreeNode(4);
root.right = new TreeNode(3);
root.right.left = new TreeNode(2);
root.right.left.left = new TreeNode(4);
root.right.right = new TreeNode(4);

// https://leetcode.com/problems/find-duplicate-subtrees
public class Solution
{
    public IList<TreeNode> FindDuplicateSubtrees(TreeNode root)
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