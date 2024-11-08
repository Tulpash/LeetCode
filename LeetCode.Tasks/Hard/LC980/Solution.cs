// 980.Unique Paths III
// https://leetcode.com/problems/unique-paths-iii/description/

// You are given an m x n integer array grid where grid[i][j] could be:
// 1 representing the starting square. There is exactly one starting square.
// 2 representing the ending square. There is exactly one ending square.
// 0 representing empty squares we can walk over.
// -1 representing obstacles that we cannot walk over.
// Return the number of 4-directional walks from the starting square to the ending square, that walk over every non-obstacle square exactly once.

namespace LeetCode.Tasks.Hard.LC980;

public class Solution
{
    private int[][] _grid = null!;
    private int _path;
    private int _count;

    public int UniquePathsIII(int[][] grid)
    {
        _count = 0;
        _grid = grid;
        _path = 1;
        int x = 0;
        int y = 0;
        for (int r = 0; r < grid.Length; r++)
            for (int c = 0; c < grid[r].Length; c++)
            {
                if (_grid[r][c] == 1)
                    (x, y) = (r, c);
                else if (_grid[r][c] == 0)
                    _path++;
            }
        DFS(x, y, 0);
        return _count;
    }

    private void DFS(int x, int y, int path)
    {
        if (x < 0 || x >= _grid.Length || y < 0 || y >= _grid[0].Length || _grid[x][y] == -1)
            return;

        if (_grid[x][y] == 2)
        {
            if (path == _path)
                _count++;
            return;
        }

        _grid[x][y] = -1;
        DFS(x, y - 1, path + 1);
        DFS(x, y + 1, path + 1);
        DFS(x - 1, y, path + 1);
        DFS(x + 1, y, path + 1);
        _grid[x][y] = 0;
    }
}