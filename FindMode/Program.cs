var solution = new Solution();
var root = new TreeNode(1);
root.right = new TreeNode(2);
root.right.left = new TreeNode(2);
Console.WriteLine(string.Join(",", solution.FindMode(root)));

// https://leetcode.com/problems/find-mode-in-binary-search-tree
public class Solution
{
    private int currVal;
    private int currCount = 0;
    private int maxCount = 0;
    private int modeCount = 0;

    private int[] modes;
    public int[] FindMode(TreeNode root)
    {
        inorder(root);
        modes = new int[modeCount];
        modeCount = 0;
        currCount = 0;
        inorder(root);
        return modes;
    }

    private void HandleValue(int val)
    {
        if (val != currVal)
        {
            currVal = val;
            currCount = 0;
        }
        currCount++;
        if (currCount > maxCount)
        {
            maxCount = currCount;
            modeCount = 1;
        }
        else if (currCount == maxCount)
        {
            if (modes != null)
                modes[modeCount] = currVal;
            modeCount++;
        }
    }

    private void inorder(TreeNode root)
    {
        TreeNode node = root;
        while (node != null)
        {
            if (node.left == null)
            {
                HandleValue(node.val);
                node = node.right;
            }
            else
            {
                TreeNode prev = node.left;
                while (prev.right != null && prev.right != node)
                {
                    prev = prev.right;
                }
                if (prev.right == null)
                {
                    prev.right = node;
                    node = node.left;
                }
                else
                {
                    prev.right = null;
                    HandleValue(node.val);
                    node = node.right;
                }
            }
        }
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