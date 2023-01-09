var solution = new Solution();
var root = new TreeNode(1);
root.left = new TreeNode(2);
root.left.left = new TreeNode(4);
root.left.right = new TreeNode(5);
root.right = new TreeNode(3);

foreach (var item in solution.PreorderTraversal(root))
{
    Console.WriteLine(item);
}

// https://leetcode.com/problems/binary-tree-preorder-traversal
public class Solution
{
    public IList<int> PreorderTraversal(TreeNode root)
    {
        var res = new List<int>();
        var stack = new Stack<TreeNode>();
        stack.Push(root);
        while (stack.Any())
        {
            var popped = stack.Pop();
            if (popped != null)
            {
                res.Add(popped.val);
                stack.Push(popped.right);
                stack.Push(popped.left);
            }
        }
        return res;
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