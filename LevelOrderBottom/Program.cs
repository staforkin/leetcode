var solution = new Solution();
var root = new TreeNode(3);
root.left = new TreeNode(9);
root.right = new TreeNode(20);
root.right.left = new TreeNode(15);
root.right.right = new TreeNode(7);
foreach (var item in solution.LevelOrderBottom(root))
{
    Console.WriteLine(string.Join(",", item));
}

// https://leetcode.com/problems/binary-tree-level-order-traversal-ii/
public class Solution
{
    public IList<IList<int>> LevelOrderBottom(TreeNode root)
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