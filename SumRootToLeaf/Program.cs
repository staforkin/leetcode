var solution = new Solution();
var root = new TreeNode(1);
root.right = new TreeNode(1);
root.right.left = new TreeNode(0);
root.right.right = new TreeNode(1);
root.left = new TreeNode(0);
root.left.left = new TreeNode(0);
root.left.right = new TreeNode(1);
Console.WriteLine(solution.SumRootToLeaf(root));

//https://leetcode.com/problems/sum-of-root-to-leaf-binary-numbers
public class Solution
{
    public int SumRootToLeaf(TreeNode root)
    {
        return dfs(root, 0);
    }

    public int dfs(TreeNode root, int val)
    {
        if (root == null)
        {
            return 0;
        }
        val = val * 2 + root.val;
        return root.left == root.right ? val : dfs(root.left, val) + dfs(root.right, val);
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