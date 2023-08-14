var solution = new Solution();
var root = new TreeNode(1);
root.left = new TreeNode(3);
root.left.left = new TreeNode(5);
root.right = new TreeNode(2);

var root2 = new TreeNode(2);
root2.left = new TreeNode(1);
root2.left.right = new TreeNode(4);
root2.right = new TreeNode(3);
root2.right.right = new TreeNode(7);
Console.WriteLine(solution.MergeTrees(root, root2));

// https://leetcode.com/problems/merge-two-binary-trees/
public class Solution
{
    public TreeNode MergeTrees(TreeNode root1, TreeNode root2)
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