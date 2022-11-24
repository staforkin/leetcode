var solution = new Solution();
var root = new Node(1);
root.right = new Node(3);
root.left = new Node(2);
root.right.left = new Node(6);
root.right.right = new Node(7);
root.left.left = new Node(4);
root.left.right = new Node(5);

solution.Connect(root);

// https://leetcode.com/problems/populating-next-right-pointers-in-each-node
public class Solution
{
    public Node Connect(Node root)
    {
        if (root == null)
        {
            return root;
        }
        var queue = new Queue<Node>();
        queue.Enqueue(root);
        while (queue.Count() > 0)
        {
            List<int> level = new List<int>();
            int cnt = queue.Count();
            for (int i = 0; i < cnt; i++)
            {
                var node = queue.Dequeue();
                if (i < cnt - 1)
                {
                    node.next = queue.Peek();
                }
                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                    queue.Enqueue(node.right);
                }
            }
        }

        return root;
    }
}


// Definition for a Node.
public class Node
{
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() { }

    public Node(int _val)
    {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next)
    {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}
