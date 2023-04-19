var solution = new Solution();
var root = new TreeNode(1);
root.right = new TreeNode(1);
root.right.right = new TreeNode(1);
root.right.right.left = new TreeNode(1);
root.right.right.left.right = new TreeNode(1);
Console.WriteLine(solution.LongestZigZag(root));

public class Solution
{
    public int LongestZigZag(TreeNode root)
    {
        return dfs(root)[2];
    }

    private int[] dfs(TreeNode root)
    {
        if (root == null)
        {
            return new int[] { -1, -1, -1 };
        }
        int[] left = dfs(root.left), right = dfs(root.right);
        int res = Math.Max(Math.Max(left[1], right[0]) + 1, Math.Max(left[2], right[2]));
        return new int[] { left[1] + 1, right[0] + 1, res };
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