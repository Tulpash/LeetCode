using LeetCode.Tasks.Medium.LC994;

namespace LeetCode.Tests.Medium.LC994;

public class Tests
{
    [Fact]
    public void Test_1()
    {
        int[][] oranges = [[2, 1, 1], [1, 1, 0], [0, 1, 1]];
        int minutes = new Solution().OrangesRotting(oranges);
        Assert.Equal(4, minutes);
    }

    [Fact]
    public void Test_2()
    {
        int[][] oranges = [[2, 1, 1], [0, 1, 1], [1, 0, 1]];
        int minutes = new Solution().OrangesRotting(oranges);
        Assert.Equal(-1, minutes);
    }

    [Fact]
    public void Test_3()
    {
        int[][] oranges = [[0, 2]];
        int minutes = new Solution().OrangesRotting(oranges);
        Assert.Equal(0, minutes);
    }

    [Fact]
    public void Test_4()
    {
        int[][] oranges = [[0]];
        int minutes = new Solution().OrangesRotting(oranges);
        Assert.Equal(0, minutes);
    }

    [Fact]
    public void Test_5()
    {
        int[][] oranges = [[2, 2], [1, 1], [0, 0], [2, 0]];
        int minutes = new Solution().OrangesRotting(oranges);
        Assert.Equal(1, minutes);
    }
}