var solution = new Solution();
var root = new Node(1);
root.children = new[] { new Node(3, new Node[] { }), new Node(2, new Node[] { }), new Node(4, new Node[] { }) };
Console.WriteLine(string.Join(",", solution.Preorder(root)));

// https://leetcode.com/problems/n-ary-tree-preorder-traversal/
public class Solution
{
    public IList<int> Preorder(Node root)
    {
        var list = new List<int>();
        if (root == null)
        {
            return list;
        }

        var stack = new Stack<Node>();
        stack.Push(root);

        while (stack.Any())
        {
            root = stack.Pop();
            list.Add(root.val);
            for (int i = root.children.Count - 1; i >= 0; i--)
            {
                stack.Push(root.children[i]);
            }
        }

        return list;
    }
}

public class Node
{
    public int val;
    public IList<Node> children;

    public Node() { }

    public Node(int _val)
    {
        val = _val;
    }

    public Node(int _val, IList<Node> _children)
    {
        val = _val;
        children = _children;
    }
}