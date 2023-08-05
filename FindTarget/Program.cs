var solution = new Solution();
var root = new TreeNode(5);
root.left = new TreeNode(3);
root.right = new TreeNode(6);
Console.WriteLine(solution.FindTarget(root, 9));

// https://leetcode.com/problems/two-sum-iv-input-is-a-bst/
public class Solution
{
    public bool FindTarget(TreeNode root, int k)
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