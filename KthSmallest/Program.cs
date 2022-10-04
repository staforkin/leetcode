var solution = new Solution();
var root = new TreeNode(3, new TreeNode(1, null, new TreeNode(2, null, null)), new TreeNode(4, null, null));
Console.WriteLine(solution.KthSmallest(root, 1));

///https://leetcode.com/problems/kth-smallest-element-in-a-bst/description/
public class Solution
{
    private static int count = 0;
    private static int number = 0;
    public int KthSmallest(TreeNode root, int k)
    {
        count = k;
        Inorder(root);
        return number;
    }

    private void Inorder(TreeNode node)
    {
        if (node == null)
        {
            return;
        }

        Inorder(node.left);
        count--;
        if (count == 0)
        {
            number = node.val;
            return;
        }
        Inorder(node.right);
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