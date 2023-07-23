var solution = new Solution();
var roots = solution.AllPossibleFBT(7);
Console.WriteLine(roots.Count);

// https://leetcode.com/problems/all-possible-full-binary-trees
public class Solution
{
    public IList<TreeNode> AllPossibleFBT(int n)
    {
        var res = new List<TreeNode>();
        if (n == 1)
        {
            res.Add(new TreeNode(0));
            return res;
        }
        n = n - 1;
        for (int i = 1; i < n; i += 2)
        {
            var left = AllPossibleFBT(i);
            var right = AllPossibleFBT(n - i);
            foreach (TreeNode nl in left)
            {
                foreach (TreeNode nr in right)
                {
                    TreeNode cur = new TreeNode(0);
                    cur.left = nl;
                    cur.right = nr;
                    res.Add(cur);
                }
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