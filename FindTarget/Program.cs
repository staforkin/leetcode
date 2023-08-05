var solution = new Solution();
var root = new TreeNode(5);
root.left = new TreeNode(3);
root.right = new TreeNode(6);
Console.WriteLine(solution.FindTarget(root, 9));

// https://leetcode.com/problems/two-sum-iv-input-is-a-bst/
public class Solution
{
    public bool FindTarget(TreeNode root, int k)
    {
        if (root == null)
        {
            return false;
        }
        var l_stack = new Stack<TreeNode>();
        var r_stack = new Stack<TreeNode>();
        stackAdd(l_stack, root, true);
        stackAdd(r_stack, root, false);
        while (l_stack.Peek() != r_stack.Peek())
        {
            int n = l_stack.Peek().val + r_stack.Peek().val;
            if (n == k)
            {
                return true;
            }
            else if (n > k)
            {
                stackNext(r_stack, false);
            }
            else
            {
                stackNext(l_stack, true);
            }
        }
        return false;
    }
    private void stackAdd(Stack<TreeNode> stack, TreeNode node, bool isLeft)
    {
        while (node != null)
        {
            stack.Push(node);
            node = (isLeft) ? node.left : node.right;
        }
    }

    private void stackNext(Stack<TreeNode> stack, bool isLeft)
    {
        TreeNode node = stack.Pop();
        if (isLeft)
        {
            stackAdd(stack, node.right, isLeft);
        }
        else
        {
            stackAdd(stack, node.left, isLeft);
        }
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