var solution = new Solution();
var root = new Node(1);
root.children = new[] { new Node(3), new Node(2), new Node(4) };
Console.WriteLine(string.Join(",", solution.Preorder(root)));

// https://leetcode.com/problems/n-ary-tree-preorder-traversal/
public class Solution
{
    public IList<int> Preorder(Node root)
    {

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