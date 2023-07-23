var solution = new Solution();
var roots = solution.AllPossibleFBT(7);
Console.WriteLine(roots.Count);

// https://leetcode.com/problems/all-possible-full-binary-trees
public class Solution
{
    public IList<TreeNode> AllPossibleFBT(int n)
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