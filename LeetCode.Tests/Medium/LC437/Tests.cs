using LeetCode.Common.Trees;
using LeetCode.Tasks.Medium.LC437;

namespace LeetCode.Tests.Medium.LC437;

public class Tests
{
    [Fact]
    public void Test_1()
    {
        int count = GetPathsCount([10, 5, -3, 3, 2, null, 11, 3, -2, null, 1], 8);
        Assert.Equal(3, count);
    }

    [Fact]
    public void Test_2()
    {
        int count = GetPathsCount([5, 4, 8, 11, null, 13, 4, 7, 2, null, null, 5, 1], 22);
        Assert.Equal(3, count);
    }

    [Fact]
    public void Test_3()
    {
        int count = GetPathsCount([1000000000, 1000000000, null, 294967296, null, 1000000000, null, 1000000000, null, 1000000000], 0);
        Assert.Equal(0, count);
    }

    private int GetPathsCount(ICollection<int?> collection, int target)
    {
        BinaryTreeNode<int>? tree = BinaryTreeBuilder.FromCollection(collection);
        return new Solution().PathSum(tree, target);
    }
}