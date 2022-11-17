var solution = new Solution();
var root = new TreeNode(3);
var left = new TreeNode(9);
var right = new TreeNode(20);
root.left = left;
root.right = right;
right.left = new TreeNode(15);
right.right = new TreeNode(7);
left.left = new TreeNode(10);
left.right = new TreeNode(13);

foreach (var item in solution.LevelOrder(root))
{
    Console.WriteLine(string.Join(",", item));
}


// https://leetcode.com/problems/binary-tree-level-order-traversal
public class Solution
{
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        var result = new List<IList<int>>();
        if (root == null)
        {
            return result;
        }
        var queue = new Queue<TreeNode>();

        queue.Enqueue(root);
        while (queue.Count() > 0)
        {
            int level = queue.Count;
            var subList = new List<int>();
            for (int i = 0; i < level; i++)
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
            result.Add(subList);
        }
        return result;
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