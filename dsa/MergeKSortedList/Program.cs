// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
static ListNode MergeKLists(ListNode[] lists)
{
    ListNode mergedList = new ListNode();
    for (int i = 0; i < lists.Length; i++)
    {
        mergedList = MergeTwoLists(mergedList, lists[i]);
    }
    return mergedList;
}

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

MergeKLists(new ListNode[] {
    new ListNode(1, new ListNode(4, new ListNode(5))),
    new ListNode(1, new ListNode(3, new ListNode(4))),
    new ListNode(2, new ListNode(6))
});
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
