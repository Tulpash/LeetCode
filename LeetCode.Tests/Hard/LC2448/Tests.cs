using LeetCode.Tasks.Hard.LC2448;

namespace LeetCode.Tests.Hard.LC2448;

public class Tests
{
    [Fact]
    public void Test_1()
    {
        long result = new Solution().MinCost([1, 3, 5, 2], [2, 3, 1, 14]);
        Assert.Equal(8, result);
    }

    [Fact]
    public void Test_2()
    {
        long result = new Solution().MinCost([2, 2, 2, 2, 2], [4, 2, 8, 1, 3]);
        Assert.Equal(0, result);
    }
}