var solution = new Solution();
var root = new TreeNode(3);
root.left = new TreeNode(9);
root.right = new TreeNode(20);
root.right.left = new TreeNode(15);
root.right.right = new TreeNode(7);
root.right.right.right = new TreeNode(11);
Console.WriteLine(solution.IsBalanced(root));

// https://leetcode.com/problems/balanced-binary-tree
public class Solution
{
    public bool IsBalanced(TreeNode root)
    {
        if (root == null)
        {
            return true;
        }
        var hLeft = HeightOf(root.left);
        var hRight = HeightOf(root.right);
        //Console.WriteLine($"{hLeft}\t{hRight}");
        return Math.Abs(hLeft - hRight) < 2 && IsBalanced(root.left) && IsBalanced(root.right);
    }

    private int HeightOf(TreeNode node)
    {
        if (node == null)
        {
            return 0;
        }
        return Math.Max(HeightOf(node.left), HeightOf(node.right)) + 1;
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