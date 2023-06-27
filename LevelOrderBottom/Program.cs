var solution = new Solution();
var root = new TreeNode(3);
root.left = new TreeNode(9);
root.right = new TreeNode(20);
root.right.left = new TreeNode(15);
root.right.right = new TreeNode(7);
foreach (var item in solution.LevelOrderBottom(root))
{
    Console.WriteLine(string.Join(",", item));
}

// https://leetcode.com/problems/binary-tree-level-order-traversal-ii/
public class Solution
{
    public IList<IList<int>> LevelOrderBottom(TreeNode root)
    {
        // BFS solution
        var queue = new Queue<TreeNode>();
        var wrapList = new List<List<int>>();

        if (root == null)
        {
            return wrapList.ToArray();
        }

        queue.Enqueue(root);
        while (queue.Any())
        {
            int levelNum = queue.Count;
            var subList = new List<int>();
            for (int i = 0; i < levelNum; i++)
            {
                if (queue.Peek().left != null)
                {
                    queue.Enqueue(queue.Peek().left);
                }
                if (queue.Peek().right != null)
                {
                    queue.Enqueue(queue.Peek().right);
                }
                subList.Add(queue.Dequeue().val);
            }
            wrapList.Insert(0, subList);
        }
        return wrapList.ToArray();
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