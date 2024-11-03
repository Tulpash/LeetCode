using LeetCode.Tasks.Medium.LC1926;

namespace LeetCode.Tests.Medium.LC1926;

public class Tests
{
    [Fact]
    public void Test_1()
    {
        int nearest = new Solution().NearestExit(
            [
                ['+', '+', '.', '+'], 
                ['.', '.', '.', '+'], 
                ['+', '+', '+', '.']
            ], [1, 2]);
        Assert.Equal(1, nearest);
    }

    [Fact]
    public void Test_2()
    {
        int nearest = new Solution().NearestExit(
            [
                ['+', '+', '+'], 
                ['.', '.', '.'], 
                ['+', '+', '+']
            ], [1, 0]);
        Assert.Equal(2, nearest);
    }

    [Fact]
    public void Test_3()
    {
        int nearest = new Solution().NearestExit(
            [
                ['.', '+']
            ], [0, 0]);
        Assert.Equal(-1, nearest);
    }

    [Fact]
    public void Test_4()
    {
        int nearest = new Solution().NearestExit(
            [
                ['+', '.', '+', '+', '+', '+', '+'], 
                ['+', '.', '+', '.', '.', '.', '+'], 
                ['+', '.', '+', '.', '+', '.', '+'], 
                ['+', '.', '.', '.', '+', '.', '+'], 
                ['+', '+', '+', '+', '+', '.', '+']
            ], [0, 1]);
        Assert.Equal(12, nearest);
    }

    [Fact]
    public void Test_5()
    {
        int nearest = new Solution().NearestExit(
            [
                ['+', '.', '+', '+', '+', '+', '+'], 
                ['+', '.', '+', '.', '.', '.', '+'], 
                ['+', '.', '+', '.', '+', '.', '+'], 
                ['+', '.', '.', '.', '.', '.', '+'], 
                ['+', '+', '+', '+', '.', '+', '.']
            ], [0, 1]);
        Assert.Equal(7, nearest);
    }
}