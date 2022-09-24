using System.Collections.Generic;

var inputRoot = new TreeNode(1, null, new TreeNode(2, new TreeNode(3, null, null), null));
var solution = new Solution();
Console.WriteLine(string.Join(",", solution.InorderTraversal(inputRoot)));

// https://leetcode.com/problems/binary-tree-inorder-traversal
public class Solution
{
    public IList<int> InorderTraversal(TreeNode root)
    {
        var result = new List<int>();
        Inorder(result, root);
        return result.ToArray();
    }

    private void Inorder(IList<int> list, TreeNode root)
    {
        if (root == null)
        {
            return;
        }
        Inorder(list,root.left);
        list.Add(root.val);
        Inorder(list, root.right);
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