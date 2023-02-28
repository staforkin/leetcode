var solution = new Solution();
var root = new TreeNode(1);
root.left = new TreeNode(2);
root.left.left = new TreeNode(4);
root.right = new TreeNode(3);
root.right.left = new TreeNode(2);
root.right.left.left = new TreeNode(4);
root.right.right = new TreeNode(4);
foreach (var item in solution.FindDuplicateSubtrees(root))
{
    Console.WriteLine(item.val);
}

// https://leetcode.com/problems/find-duplicate-subtrees
public class Solution
{
    public IList<TreeNode> FindDuplicateSubtrees(TreeNode root)
    {
        List<TreeNode> res = new List<TreeNode>();
        var map = new Dictionary<string, int>();
        postorder(root, map, res);
        return res;
    }

    public string postorder(TreeNode cur, Dictionary<string, int> map, List<TreeNode> res)
    {
        if (cur == null)
        {
            return "#";
        }
        string serial = cur.val + "," + postorder(cur.left, map, res) + "," + postorder(cur.right, map, res);
        if (map.ContainsKey(serial))
        {
            map[serial] += 1;
        }
        else
        {
            map.Add(serial, 1);
        }
        if (map[serial] == 2)
        {
            res.Add(cur);
        }
        return serial;
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