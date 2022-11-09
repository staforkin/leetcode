var solution = new Solution();
var root = new TreeNode(1);
// var left2 = new TreeNode(2);
// var right2 = new TreeNode(2);
// var left3 = new TreeNode(3);
// var right3 = new TreeNode(3);
// var left4 = new TreeNode(4);
// var right4 = new TreeNode(4);
// root.left = left2;
// root.right = right2;
// left2.left = left3;
// left2.right = left4;
// right2.left = right4;
// right2.right = right3;
root.left = new TreeNode(2, new TreeNode(2));
root.right = new TreeNode(2, null, new TreeNode(2));

Console.WriteLine(solution.IsSymmetric(root));

//https://leetcode.com/problems/symmetric-tree/
public class Solution
{
    public bool IsSymmetric(TreeNode root)
    {
        return isSymmetricHelp(root.left, root.right);
    }
    private void Dfs(IList<int> list, TreeNode node)
    {
        if (node == null)
        {
            list.Add(101);
            return;
        }
        Dfs(list, node.left);
        list.Add(node.val);
        Dfs(list, node.right);
    }
    private bool isSymmetricHelp(TreeNode left, TreeNode right)
    {
        if (left == null || right == null)
            return left == right;
        if (left.val != right.val)
            return false;
        return isSymmetricHelp(left.left, right.right) && isSymmetricHelp(left.right, right.left);
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
