var solution = new Solution();
var root = new TreeNode(1);
root.right = new TreeNode(2);
root.right.left = new TreeNode(3);
Console.WriteLine(string.Join(',', solution.PostorderTraversal(root)));

// https://leetcode.com/problems/binary-tree-postorder-traversal
public class Solution
{
    public IList<int> PostorderTraversal(TreeNode root)
    {
        var list = new List<int>();
        if (root == null)
        {
            return Array.Empty<int>();
        }
        Helper(root, list);
        return list;
    }

    private void Helper(TreeNode node, IList<int> list)
    {
        if (node == null)
        {
            return;
        }
        Helper(node.left, list);
        Helper(node.right, list);
        list.Add(node.val);
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