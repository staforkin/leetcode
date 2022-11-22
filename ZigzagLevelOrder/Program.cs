var solution = new Solution();
var root = new TreeNode(3);
root.left = new TreeNode(9);
root.right = new TreeNode(20);
root.right.left = new TreeNode(15);
root.right.right = new TreeNode(7);
var res = solution.ZigzagLevelOrder(root);

foreach (var item in res)
{
    Console.WriteLine(string.Join(",",item));
}

// https://leetcode.com/problems/binary-tree-zigzag-level-order-traversal/
public class Solution
{
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
    {
        List<IList<int>> res = new List<IList<int>>();
        if (root == null) return res;
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        bool zigzag = false;
        while (queue.Count() > 0)
        {
            List<int> level = new List<int>();
            int cnt = queue.Count();
            for (int i = 0; i < cnt; i++)
            {
                TreeNode node = queue.Dequeue();
                if (zigzag)
                {
                    level.Insert(0,node.val);
                }
                else
                {
                    level.Add(node.val);
                }
                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }
                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }
            }
            res.Add(level);
            zigzag = !zigzag;
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