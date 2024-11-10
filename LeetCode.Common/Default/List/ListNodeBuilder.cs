namespace LeetCode.Common.Default.List;

public static class ListNodeBuilder
{
    public static ListNode? FromCollection(ICollection<int> collection)
    {
        if (collection == null || collection.Count == 0)
            return null;

        ListNode head = new();
        ListNode? current = head.next;
        IEnumerator<int> enumerator = collection.GetEnumerator();
        while (enumerator.MoveNext())
        {
            current = new(enumerator.Current);
            current = current.next;
        }
        return head.next;
    }
}