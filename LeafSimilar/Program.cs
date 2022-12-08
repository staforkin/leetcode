var solution = new Solution();
var root1 = new TreeNode();
var root2 = new TreeNode();
Console.WriteLine(solution.LeafSimilar(root1, root2));

// https://leetcode.com/problems/leaf-similar-trees
public class Solution {
    public bool LeafSimilar(TreeNode root1, TreeNode root2) {
        
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