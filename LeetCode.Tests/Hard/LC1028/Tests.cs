using LeetCode.Common.Default;
using LeetCode.Tasks.Hard.LC1028;

namespace LeetCode.Tests.Hard.LC1028;

public class Tests
{
    [Fact]
    public void Test_1()
    {
        TreeNode? root = new Solution().RecoverFromPreorder("1-2--3--4-5--6--7");
        TreeNode? result = TreeNodeBuilder.FromCollection([1, 2, 5, 3, 4, 6, 7]);
        Assert.True(TreeNode.Equals(result, root));
    }

    [Fact]
    public void Test_2()
    {
        TreeNode? root = new Solution().RecoverFromPreorder("1-2--3---4-5--6---7");
        TreeNode? result = TreeNodeBuilder.FromCollection([1, 2, 5, 3, null, 6, null, 4, null, 7]);
        Assert.True(TreeNode.Equals(result, root));
    }

    [Fact]
    public void Test_3()
    {
        TreeNode? root = new Solution().RecoverFromPreorder("1-401--349---90--88");
        TreeNode? result = TreeNodeBuilder.FromCollection([1, 401, null, 349, 88, 90]);
        Assert.True(TreeNode.Equals(result, root));
    }
}