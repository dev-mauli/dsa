Console.WriteLine("Hello, World!");


static Node rotate(Node head, int k)
{
    if (head == null || head.next == null || k <= 0)
        return head;

    int length = 1;
    Node tail = head;

    while (tail.next != null)
    {
        tail = tail.next;
        length++;
    }

    k = k % length;
    if (k == 0) return head;

    Node current = head;
    for (int i = 1; i < k; i++)
    {
        current = current.next;
    }

    Node newHead = current.next;
    current.next = null;
    tail.next = head;

    return newHead;
}

rotate(new Node(10) { next = new Node(20) { next = new Node(30) { next = new Node(40) { next = new Node(50) } } } }, 4);

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