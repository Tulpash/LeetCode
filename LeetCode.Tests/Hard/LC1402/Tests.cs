using LeetCode.Tasks.Hard.LC1402;

namespace LeetCode.Tests.Hard.LC1402;

public class Tests
{
    [Fact]
    public void Test_1()
    {
        int satisfaction = new Solution().MaxSatisfaction([-1, -8, 0, 5, -7]);
        Assert.Equal(14, satisfaction);
    }

    [Fact]
    public void Test_2()
    {
        int satisfaction = new Solution().MaxSatisfaction([4, 3, 2]);
        Assert.Equal(20, satisfaction);
    }

    [Fact]
    public void Test_3()
    {
        int satisfaction = new Solution().MaxSatisfaction([-1, -4, -5]);
        Assert.Equal(0, satisfaction);
    }
}