var solution = new Solution();
var root = new TreeNode(2);
root.left = new TreeNode(3);
root.right = new TreeNode(4);
// 2
//3 4
// 5*4 = 20
// 6*3 = 18

// https://leetcode.com/problems/maximum-product-of-splitted-binary-tree/
public class Solution
{
    public int MaxProduct(TreeNode root)
    {
        
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
