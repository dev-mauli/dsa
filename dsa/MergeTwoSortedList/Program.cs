// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


static ListNode MergeTwoLists(ListNode list1, ListNode list2)
{
    if (list1 == null) return list2;
    if (list2 == null) return list1;

    // Recursive merge
    if (list1.val <= list2.val)
    {
        list1.next = MergeTwoLists(list1.next, list2);
        return list1;
    }
    else
    {
        list2.next = MergeTwoLists(list1, list2.next);
        return list2;
    }
}

MergeTwoLists(new ListNode(1, new ListNode(2, new ListNode(4))), new ListNode(1, new ListNode(3, new ListNode(4))));

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
