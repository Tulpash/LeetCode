using LeetCode.Tasks.Hard.LC4;

namespace LeetCode.Tests.Hard.LC4;

public class Test
{
    [Fact]
    public void Test_1()
    {
        double result = new Solution().FindMedianSortedArrays([1, 3], [2]);
        Assert.Equal(2d, result);
    }

    [Fact]
    public void Test_2()
    {
        double result = new Solution().FindMedianSortedArrays([1, 2], [3, 4]);
        Assert.Equal(2.5d, result);
    }
}