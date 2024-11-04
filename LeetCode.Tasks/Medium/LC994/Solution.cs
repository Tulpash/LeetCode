// 994. Rotting Oranges
// https://leetcode.com/problems/rotting-oranges/description

// You are given an m x n grid where each cell can have one of three values:
// 0 representing an empty cell,
// 1 representing a fresh orange, or
// 2 representing a rotten orange.
// Every minute, any fresh orange that is 4-directionally adjacent to a rotten orange becomes rotten.
// Return the minimum number of minutes that must elapse until no cell has a fresh orange. If this is impossible, return -1.

namespace LeetCode.Tasks.Medium.LC994;

public class Solution
{
    public int OrangesRotting(int[][] grid)
    {
        int freshCount = 0;
        Queue<GridPoint> queue = new();
        int m = grid.Length;
        int n = grid[0].Length;
        for (int r = 0; r < m; r++)
            for (int c = 0; c < n; c++)
                if (grid[r][c] == 2)
                    queue.Enqueue(new() { X = r, Y = c, Minute = 3 });
                else if (grid[r][c] == 1)
                    freshCount++;
        if (freshCount == 0)
            return 0;
        if (queue.Count == 0)
            return -1;
        while (queue.TryDequeue(out GridPoint point))
        {
            if (grid[point.X][point.Y] > 3)
                continue;
            grid[point.X][point.Y] = point.Minute;
            int offset = point.X - 1;
            if (offset >= 0 && grid[offset][point.Y] == 1)
            {
                queue.Enqueue(new() { X = offset, Y = point.Y, Minute = point.Minute + 1 });
            }
            offset = point.X + 1;
            if (offset < m && grid[offset][point.Y] == 1)
            {
                queue.Enqueue(new() { X = offset, Y = point.Y, Minute = point.Minute + 1 });
            }
            offset = point.Y - 1;
            if (offset >= 0 && grid[point.X][offset] == 1)
            {
                queue.Enqueue(new() { X = point.X, Y = offset, Minute = point.Minute + 1 });
            }
            offset = point.Y + 1;
            if (offset < n && grid[point.X][offset] == 1)
            {
                queue.Enqueue(new() { X = point.X, Y = offset, Minute = point.Minute + 1 });
            }
        }
        int max = 3;
        for (int r = 0; r < m; r++)
            for (int c = 0; c < n; c++)
                if (grid[r][c] == 1)
                    return -1;
                else if (grid[r][c] > max)
                    max = grid[r][c];
        return max - 3;
    }

    public struct GridPoint
    {
        public int X;
        public int Y;
        public int Minute;
    }
}