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
        var res = new List<string>();
        if (root != null)
        {
            searchBT(root, "", res);
        }
        return res;
    }
    private void searchBT(TreeNode root, string path, List<string> res)
    {
        if (root.left == null && root.right == null)
        {
            res.Add(path + root.val);
        }

        if (root.left != null)
        {
            searchBT(root.left, path + root.val + "->", res);
        }
        if (root.right != null)
        {
            searchBT(root.right, path + root.val + "->", res);
        }
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