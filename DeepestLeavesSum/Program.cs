var solution = new Solution();
var root = new TreeNode(1);
root.right = new TreeNode(3);
root.right.right = new TreeNode(6);
root.right.right.right = new TreeNode(8);
root.left = new TreeNode(2);
root.left.right = new TreeNode(5);
root.left.left = new TreeNode(4);
root.left.left.left = new TreeNode(7);
Console.WriteLine(solution.DeepestLeavesSum(root));

// https://leetcode.com/problems/deepest-leaves-sum/
public class Solution
{
    public int DeepestLeavesSum(TreeNode root)
    {
        int res = 0, i;
        var q = new LinkedList<TreeNode>();
        q.AddLast(root);
        while (q.Any())
        {
            for (i = q.Count() - 1, res = 0; i >= 0; --i)
            {
                TreeNode node = q.First();
                q.RemoveFirst();
                res += node.val;
                if (node.right != null)
                    q.AddLast(node.right);
                if (node.left != null)
                    q.AddLast(node.left);
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