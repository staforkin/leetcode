var solution = new Solution();
var root = new TreeNode(1);
root.left = new TreeNode(2);
root.right = new TreeNode(3);
Console.WriteLine(solution.SumNumbers(root));

// https://leetcode.com/problems/sum-root-to-leaf-numbers/
public class Solution
{
    public int SumNumbers(TreeNode root)
    {
        return Helper(root, 0);
    }

    private int Helper(TreeNode node, int sum)
    {
        if (node == null)
        {
            return 0;
        }
        if (node.left == null && node.right == null)
        {
            return sum * 10 + node.val;
        }
        return Helper(node.left, sum * 10 + node.val) + Helper(node.right, sum * 10 + node.val);
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