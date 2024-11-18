using LeetCode.Tasks.Easy.LC1232;

namespace LeetCode.Tests.Easy.LC1232;

public class Tests
{
    [Fact]
    public void Test_1()
    {
        bool result = new Solution().CheckStraightLine([[1, 2], [2, 3], [3, 4], [4, 5], [5, 6], [6, 7]]);
        Assert.True(result);
    }

    [Fact]
    public void Test_2()
    {
        bool result = new Solution().CheckStraightLine([[1, 1], [2, 2], [3, 4], [4, 5], [5, 6], [7, 7]]);
        Assert.False(result);
    }
}