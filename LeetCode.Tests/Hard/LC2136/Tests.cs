using LeetCode.Tasks.Hard.LC2136;

namespace LeetCode.Tests.Hard.LC2136;

public class Tests
{
    [Fact]
    public void Test_1()
    {
        int time = new Solution().EarliestFullBloom([1, 4, 3], [2, 3, 1]);
        Assert.Equal(9, time);
    }

    [Fact]
    public void Test_2()
    {
        int time = new Solution().EarliestFullBloom([1, 2, 3, 2], [2, 1, 2, 1]);
        Assert.Equal(9, time);
    }

    [Fact]
    public void Test_3()
    {
        int time = new Solution().EarliestFullBloom([1], [1]);
        Assert.Equal(2, time);
    }
}