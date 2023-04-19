var solution = new Solution();
var root = new TreeNode(1);
root.right = new TreeNode(1);
root.right.right = new TreeNode(1);
root.right.right.left = new TreeNode(1);
root.right.right.left.right = new TreeNode(1);
Console.WriteLine(solution.LongestZigZag(root));

public class Solution
{
    public int LongestZigZag(TreeNode root)
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