using LeetCode.Tasks.Hard.LC41;

namespace LeetCode.Tests.Hard.LC41;

public class Tests
{
    [Fact]
    public void Test_1() 
    {
        int result = new Solution().FirstMissingPositive([1, 2, 0]);
        Assert.Equal(3, result);
    }

    [Fact]
    public void Test_2()
    {
        int result = new Solution().FirstMissingPositive([3, 4, -1, 1]);
        Assert.Equal(2, result);
    }

    [Fact]
    public void Test_3()
    {
        int result = new Solution().FirstMissingPositive([7, 8, 9, 11, 12]);
        Assert.Equal(1, result);
    }
}