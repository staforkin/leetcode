var solution = new Solution();
var root = new TreeNode(1);
root.left = new TreeNode(2);
root.right = new TreeNode(3);

Console.WriteLine(solution.MaxPathSum(root));

// https://leetcode.com/problems/binary-tree-maximum-path-sum
public class Solution
{
    public int MaxSum = int.MinValue;
    public int MaxPathSum(TreeNode root)
    {
        MaxGain(root);
        return MaxSum;
    }
    public int MaxGain(TreeNode node)
    {
        if (node == null) return 0;

        int leftGain = Math.Max(MaxGain(node.left), 0);
        int rightGain = Math.Max(MaxGain(node.right), 0);

        int priceNewPath = node.val + leftGain + rightGain;

        MaxSum = Math.Max(MaxSum, priceNewPath);

        return node.val + Math.Max(leftGain, rightGain);
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