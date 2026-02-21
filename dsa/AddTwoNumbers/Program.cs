Console.WriteLine("Hello, World!");

static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
{
    int carry = 0;
    ListNode result = new ListNode(0);
    ListNode ptr = result;

    while (l1 != null || l2 != null)
    {
        int sum = carry + 0;
        if (l1 != null)
        {
            sum += l1.val;
            l1 = l1.next;
        }
        if (l2 != null)
        {
            sum += l2.val;
            l2 = l2.next;
        }
        carry = sum / 10;
        sum = sum % 10;

        ptr.next = new ListNode(sum);
        ptr = ptr.next;
    }

    if (carry == 1)
    {
        ptr.next = new ListNode(1);
    }

    return result.next;
}

AddTwoNumbers(new ListNode(2) { next = new ListNode(4) { next = new ListNode(3) } }, new ListNode(5) { next = new ListNode(6) { next = new ListNode(4) } });

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