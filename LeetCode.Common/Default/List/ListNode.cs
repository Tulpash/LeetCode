
namespace LeetCode.Common.Default.List;

public class ListNode
{
    public int val;
    public ListNode? next;

    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(val, next != null ? next.val.GetHashCode() : 0);
    }

    public override bool Equals(object? other) => Equals(other as ListNode);

    public bool Equals(ListNode? other) => Equals(this, other);

    public static bool Equals(ListNode? first, ListNode? second)
    {
        bool allIsNull = first == null && second == null;
        if (allIsNull)
            return true;

        bool allIsNotNull = first != null && second != null;
        if (!allIsNotNull)
            return false;

        if (first?.val != second?.val)
            return false;

        return Equals(first?.next, second?.next);
    }
}