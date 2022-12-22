var solution = new Solution();
var root = new TreeNode(4);
root.left = new TreeNode(2);
root.right = new TreeNode(7);
root.left.left = new TreeNode(1);
root.left.right = new TreeNode(3);
root.right.left = new TreeNode(6);
root.right.right = new TreeNode(9);
var newRoot = solution.InvertTree(root);
var t = newRoot;
var queue = new Queue<TreeNode>();
queue.Enqueue(t);
while (queue.Any())
{
    var node = queue.Dequeue();
    if (node != null)
    {
        Console.Write($"{node.val} ");
        queue.Enqueue(node.left);
        queue.Enqueue(node.right);
    }
}

public class Solution
{
    public TreeNode InvertTree(TreeNode root)
    {
        if(root==null)
        {
            return root;
        }
        var tLeft = root.left;
        root.left = root.right;
        root.right = tLeft;
        InvertTree(root.left);
        InvertTree(root.right);
        return root;
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