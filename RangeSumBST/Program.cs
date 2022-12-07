var solution = new Solution();
var root = new TreeNode(10);
root.left = new TreeNode(5);
root.right = new TreeNode(15);
root.left.left = new TreeNode(3);
root.left.right = new TreeNode(7);
root.right.right = new TreeNode(18);

Console.WriteLine(solution.RangeSumBST2(root, 7, 15));

// https://leetcode.com/problems/range-sum-of-bst
public class Solution
{
    public int RangeSumBST(TreeNode root, int low, int high)
    {
        if (root == null)
        {
            return 0;
        }
        return root.val >= low && root.val <= high
            ? root.val + RangeSumBST(root.left, low, high) + RangeSumBST(root.right, low, high)
            : RangeSumBST(root.left, low, high) + RangeSumBST(root.right, low, high);
    }

    public int RangeSumBST2(TreeNode root, int low, int high)
    {
        if (root == null)
        {
            return 0;
        }
        if (root.val > high)
        {
            return RangeSumBST2(root.left, low, high);
        }
        else if (root.val < low)
        {
            return RangeSumBST2(root.right, low, high);
        }

        return root.val + RangeSumBST2(root.right, low, high) + RangeSumBST2(root.left, low, high);
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
