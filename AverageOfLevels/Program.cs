var solution = new Solution();
var root = new TreeNode(2147483647);
root.left = new TreeNode(2147483647);
root.right = new TreeNode(2147483647);
root.right.right = new TreeNode(7);
root.right.left = new TreeNode(15);

foreach (var item in solution.AverageOfLevels(root))
{
    Console.WriteLine(item);
}

// https://leetcode.com/problems/average-of-levels-in-binary-tree
public class Solution
{
    public IList<double> AverageOfLevels(TreeNode root)
    {
        var res = new List<double>();
        var q = new Queue<TreeNode>();
        q.Enqueue(root);
        while (q.Any())
        {
            var cnt = q.Count();
            long sum = default;
            for (int i = 0; i < cnt; i++)
            {
                var t = q.Dequeue();
                if (t.left != null)
                {
                    q.Enqueue(t.left);
                }
                if (t.right != null)
                {
                    q.Enqueue(t.right);
                }
                sum += t.val;
            }
            res.Add((double)sum / cnt);
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