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

var res = solution.MergeTrees(root, root2);
Console.WriteLine(res.val);

// https://leetcode.com/problems/merge-two-binary-trees/
public class Solution
{
    public TreeNode MergeTrees(TreeNode root1, TreeNode root2)
    {
        if (root1 == null)
        {
            return root2;
        }
        if (root2 == null)
        {
            return root1;
        }

        TreeNode node = new TreeNode(root1.val + root2.val);
        node.left = MergeTrees(root1.left, root2.left);
        node.right = MergeTrees(root1.right, root2.right);
        return node;
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