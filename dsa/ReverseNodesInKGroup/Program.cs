using System.Xml.Linq;

Console.WriteLine("Hello, World!");

static ListNode ReverseKGroup(ListNode head, int k)
{
    if (head == null) return null;

    // Check if there are at least k nodes
    ListNode temp = head;
    for (int i = 0; i < k; i++)
    {
        if (temp == null)
            return head; // Not enough nodes → no reverse
        temp = temp.next;
    }

    // Reverse k nodes
    ListNode prev = null;
    ListNode curr = head;
    ListNode next = null;
    int count = 0;

    while (curr != null && count < k)
    {
        next = curr.next;
        curr.next = prev;
        prev = curr;
        curr = next;
        count++;
    }

    // Recursively process remaining list
    if (next != null)
    {
        head.next = ReverseKGroup(next, k);
    }

    return prev;
}

ReverseKGroup(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5))))), 2);

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}