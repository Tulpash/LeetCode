using LeetCode.Tasks.Easy.LC2591;

namespace LeetCode.Tests.Easy.LC2591;

public class Test
{
    [Fact]
    public void Test_1()
    {
        int result = new Solution().DistMoney(20, 3);
        Assert.Equal(1, result);
    }

    [Fact]
    public void Test_2()
    {
        int result = new Solution().DistMoney(16, 2);
        Assert.Equal(2, result);
    }
}