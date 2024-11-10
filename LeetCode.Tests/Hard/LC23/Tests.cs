using LeetCode.Common.Default.List;
using LeetCode.Tasks.Hard.LC23;

namespace LeetCode.Tests.Hard.LC23;

public class Tests
{
    [Fact]
    public void Test_1()
    {
        ListNode? result = new Solution().MergeKLists(
            GetListsFromCollection([[1, 4, 5], [1, 3, 4], [2, 6]])
            );
        ListNode? expected = ListNodeBuilder.FromCollection([1, 1, 2, 3, 4, 4, 5, 6]);
        Assert.True(Equals(result, expected));
    }

    [Fact]
    public void Test_2()
    {
        ListNode? result = new Solution().MergeKLists(
            GetListsFromCollection([])
            );
        ListNode? expected = ListNodeBuilder.FromCollection([]);
        Assert.True(Equals(result, expected));
    }

    [Fact]
    public void Test_3()
    {
        ListNode? result = new Solution().MergeKLists(
            GetListsFromCollection([[]])
            );
        ListNode? expected = ListNodeBuilder.FromCollection([]);
        Assert.True(Equals(result, expected));
    }

    private ListNode[]? GetListsFromCollection(ICollection<ICollection<int>> lists)
    {
        if (lists == null || lists.Count == 0)
            return null;

        ListNode[] result = new ListNode[lists.Count];
        IEnumerator<ICollection<int>> enumerator = lists.GetEnumerator();
        int i = 0;
        while (enumerator.MoveNext())
        {
            result[i] = ListNodeBuilder.FromCollection(enumerator.Current);
            i++;
        }
        return result;  
    }
}