using LeetCode.Tasks.Hard.LC239;

namespace LeetCode.Tests.Hard.LC239;

public class Tests
{
    [Fact]
    public void Test_1() 
    {
        int[] result = new Solution().MaxSlidingWindow([1, 3, -1, -3, 5, 3, 6, 7], 3);
        int[] expected = [3, 3, 5, 5, 6, 7];
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test_2()
    {
        int[] result = new Solution().MaxSlidingWindow([1], 1);
        int[] expected = [1];
        Assert.Equal(expected, result);
    }
}