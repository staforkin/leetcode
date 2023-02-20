var solution = new Solution();
var root = new TreeNode(1);
root.right = new TreeNode(3);
root.left = new TreeNode(2);
root.left.right = new TreeNode(5);
foreach (var item in solution.BinaryTreePaths(root))
{
    Console.WriteLine(item);
}

// https://leetcode.com/problems/binary-tree-paths
public class Solution
{
    public IList<string> BinaryTreePaths(TreeNode root)
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