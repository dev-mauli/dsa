Console.WriteLine("Hello, World!");

static ListNode SwapPairs(ListNode head)
{
    ListNode dummy = new ListNode(0) { next = head };
    ListNode prev = dummy;
    ListNode current = head;

    while (current != null && current.next != null)
    {
        ListNode nextPair = current.next.next;
        ListNode second = current.next;

        second.next = current;
        current.next = nextPair;
        prev.next = second;

        prev = current;
        current = nextPair;
    }
    return dummy.next;
}

SwapPairs(new ListNode(1) { next = new ListNode(2) { next = new ListNode(3) { next = new ListNode(4) } } });

class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int x)
    {
        val = x;
        next = null;
    }
}
