var solution = new Solution();
var root1 = new TreeNode(1);
root1.left = new TreeNode(2);
root1.right = new TreeNode(3);
var root2 = new TreeNode(1);
root2.left = new TreeNode(2);
root2.right = new TreeNode(3);

Console.WriteLine(solution.IsSameTree(root1, root2));

// https://leetcode.com/problems/same-tree
public class Solution
{
    public bool IsSameTree(TreeNode p, TreeNode q)
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
