using LeetCode.Tasks.Easy.LC605;

namespace LeetCode.Tests.Easy.LC605;

public class Tests
{
    [Fact]
    public void Test_1()
    {
        bool result = new Solution().CanPlaceFlowers([1, 0, 0, 0, 1], 1);
        Assert.True(result);
    }

    [Fact]
    public void Test_2()
    {
        bool result = new Solution().CanPlaceFlowers([1, 0, 0, 0, 1], 2);
        Assert.False(result);
    }
}