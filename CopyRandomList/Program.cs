var solution = new Solution();


public class Solution
{
    public Node CopyRandomList(Node head)
    {
        if (head == null)
        {
            return null;
        }

        var c = head;
        while (c != null)
        {
            Node next = c.next;
            c.next = new Node(c.val);
            c.next.next = next;
            c = next;
        }

        c = head;
        while (c != null)
        {
            if (c.random != null)
            {
                c.next.random = c.random.next;
            }
            c = c.next.next;
        }

        c = head;
        var copyHead = head.next;
        var copy = copyHead;

        while (copy.next != null)
        {
            c.next = c.next.next;
            c = c.next;

            copy.next = copy.next.next;
            copy = copy.next;
        }
        c.next = c.next.next;

        return copyHead;
    }
}

public class Node
{
    public int val;
    public Node next;
    public Node random;

    public Node(int _val)
    {
        val = _val;
        next = null;
        random = null;
    }
}