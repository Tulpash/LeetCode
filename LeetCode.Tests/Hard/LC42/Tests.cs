using LeetCode.Tasks.Hard.LC42;

namespace LeetCode.Tests.Hard.LC42;

public class Tests
{
    [Fact]
    public void Test_1()
    {
        int res = new Solution().Trap([0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1]);
        Assert.Equal(6, res);
    }


    [Fact]
    public void Test_2()
    {
        int res = new Solution().Trap([4, 2, 0, 3, 2, 5]);
        Assert.Equal(9, res);
    }
}