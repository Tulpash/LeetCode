using LeetCode.Tasks.Hard.LC980;

namespace LeetCode.Tests.Hard.LC980;

public class Tests
{
    [Fact]
    public void Test_1()
    {
        int pathCount = new Solution().UniquePathsIII([[1, 0, 0, 0], [0, 0, 0, 0], [0, 0, 2, -1]]);
        Assert.Equal(2, pathCount);
    }

    [Fact]
    public void Test_2()
    {
        int pathCount = new Solution().UniquePathsIII([[1, 0, 0, 0], [0, 0, 0, 0], [0, 0, 0, 2]]);
        Assert.Equal(4, pathCount);
    }

    [Fact]
    public void Test_3()
    {
        int pathCount = new Solution().UniquePathsIII([[0, 1], [2, 0]]);
        Assert.Equal(0, pathCount);
    }
}