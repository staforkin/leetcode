var solution = new Solution();
var root = new TreeNode(1);
root.left = new TreeNode(2);
root.right = new TreeNode(3);
root.left.left = new TreeNode(4);
root.left.right = new TreeNode(5);
root.right.left = new TreeNode(6);
Console.WriteLine(solution.IsCompleteTree(root));

// https://leetcode.com/problems/check-completeness-of-a-binary-tree/
public class Solution
{
    public bool IsCompleteTree(TreeNode root)
    {
        var bfs = new Queue<TreeNode>();
        bfs.Enqueue(root);
        while (bfs.Peek() != null)
        {
            TreeNode node = bfs.Dequeue();
            bfs.Enqueue(node.left);
            bfs.Enqueue(node.right);
        }
        while (bfs.Count>0 && bfs.Peek() == null)
        {
            bfs.Dequeue();
        }
        return bfs.Count==0;
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