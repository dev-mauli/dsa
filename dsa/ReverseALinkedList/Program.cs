using System.Xml.Linq;

Console.WriteLine("Hello, World!");


static Node reverseList(Node head)
{
    // code here
    return reverseListHelper(head, null);
}

static Node reverseListHelper(Node current, Node prev)
{
    if (current == null)
        return prev;

    Node next = current.next;
    current.next = prev;

    return reverseListHelper(next, current);
}

reverseList(new Node(1)
{
    next = new Node(2)
    {
        next = new Node(3)
        {
            next = new Node(4)
            {
                next = new Node(5)
            }
        }
    }
});

class Node
{
    public int data;
    public Node next;

    public Node(int x)
    {
        data = x;
        next = null;
    }
}
