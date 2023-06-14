var solution = new Solution();
var root = new TreeNode(4);
root.right = new TreeNode(6);
root.left = new TreeNode(2);
root.left.left = new TreeNode(1);
root.left.right = new TreeNode(3);
Console.WriteLine(solution.GetMinimumDifference(root));

// https://leetcode.com/problems/minimum-absolute-difference-in-bst
public class Solution
{
    int min = int.MaxValue;
    int? prev = null;
    public int GetMinimumDifference(TreeNode root)
    {
        if (root == null) return min;

        GetMinimumDifference(root.left);

        if (prev != null)
        {
            min = Math.Min(min, root.val - prev.Value);
        }
        prev = root.val;

        GetMinimumDifference(root.right);

        return min;
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