var solution = new Solution();
var root = new TreeNode(3);
root.left = new TreeNode(9);
root.right = new TreeNode(20);
root.right.left = new TreeNode(15);
root.right.right = new TreeNode(7);
Console.WriteLine(solution.SumOfLeftLeaves(root));

// https://leetcode.com/problems/sum-of-left-leaves
public class Solution
{
    public int SumOfLeftLeaves(TreeNode root)
    {
        if(root.left is null && root.right is null){
            return 0;
        }
        return HelperLeft(root.left)+Helper(root.right);
    }

    public int HelperLeft(TreeNode root)
    {
        if (root is null)
        {
            return 0;
        }
        return root.left is null && root.right is null ? root.val : HelperLeft(root.left) + Helper(root.right);
    }

    public int Helper(TreeNode root)
    {
        if (root is null)
        {
            return 0;
        }
        return HelperLeft(root.left) + Helper(root.right);
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