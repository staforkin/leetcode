var solution = new Solution();
var root = new Node(1);
root.children = new[] { new Node(3, new Node[] { }), new Node(2, new Node[] { }), new Node(4, new Node[] { }) };
Console.WriteLine(string.Join(",", solution.Postorder(root)));

//https://leetcode.com/problems/n-ary-tree-postorder-traversal
public class Solution
{
    public IList<int> Postorder(Node root)
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
            foreach (Node node in root.children)
            {
                stack.Push(node);
            }
        }
        list.Reverse();
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