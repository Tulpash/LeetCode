using LeetCode.Common.Default.Tree;
using LeetCode.Tasks.Hard.LC124;

namespace LeetCode.Tests.Hard.LC124;

public class Test
{
    [Fact]
    public void Test_1()
    {
        TreeNode? root = TreeNodeBuilder.FromCollection([1, 2, 3]);
        int result = new Solution().MaxPathSum(root);
        Assert.Equal(6, result);
    }

    [Fact]
    public void Test_2()
    {
        TreeNode? root = TreeNodeBuilder.FromCollection([-10, 9, 20, null, null, 15, 7]);
        int result = new Solution().MaxPathSum(root);
        Assert.Equal(42, result);
    }
}