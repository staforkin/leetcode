using System.Text;

var solution = new Solution();
var root = solution.buildTree(new int?[] { 3, 9, 20, null, null, 15, 7 });
Console.WriteLine(solution.MaxDepth(root));

// https://leetcode.com/problems/maximum-depth-of-binary-tree/
public class Solution
{
    public int MaxDepth(TreeNode root)
    {
        var resList = new List<int>();
        int res = 0;
        Inorder(root,res, resList);
        return resList.Max();
    }

    private void Inorder(TreeNode node, int res, List<int> resList){
        if(node == null){
            resList.Add(res);
            return;
        }
        res++;
        Inorder(node.left, res, resList);
        Inorder(node.right, res, resList);
    }

    public TreeNode buildTree(IList<int?> arr)
    {
        TreeNode root = null;
        Queue<TreeNode> q = new Queue<TreeNode>();
        int i = 0;
        TreeNode t = arr[i] == null ? null : new TreeNode(arr[i].Value);
        root = t;
        q.Enqueue(root);
        i++;
        while (q.Count != 0 && i < arr.Count)
        {
            TreeNode t1 = q.Dequeue();
            if (t1 != null)
            {
                t1.left = arr[i] == null ? null : new TreeNode(arr[i].Value);
                q.Enqueue(t1.left);
                i++;
                if (i >= arr.Count)
                {
                    break;
                }
                t1.right = arr[i] == null ? null : new TreeNode(arr[i].Value);
                q.Enqueue(t1.right);
                i++;
            }
        }
        printLevelOrder(root);
        return root;
    }
    private void printLevelOrder(TreeNode root)
    {
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);
        StringBuilder sb = new StringBuilder();
        while (q.Count != 0)
        {
            TreeNode t = q.Dequeue();
            sb.Append(t == null ? "null" : t.val).Append(", ");
            if (t != null)
            {
                q.Enqueue(t.left);
                q.Enqueue(t.right);
            }
        }
        Console.WriteLine(sb.ToString());
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