// 1926. Nearest Exit from Entrance in Maze
// https://leetcode.com/problems/nearest-exit-from-entrance-in-maze/description

// You are given an m x n matrix maze (0-indexed) with empty cells (represented as '.') and walls (represented as '+'). You are also given the entrance of the maze, where entrance = [entrancerow, entrancecol] denotes the row and column of the cell you are initially standing at.
// In one step, you can move one cell up, down, left, or right. You cannot step into a cell with a wall, and you cannot step outside the maze. Your goal is to find the nearest exit from the entrance. An exit is defined as an empty cell that is at the border of the maze. The entrance does not count as an exit.
// Return the number of steps in the shortest path from the entrance to the nearest exit, or -1 if no such path exists.


namespace LeetCode.Tasks.Medium.LC1926;

public class Solution
{
    public int NearestExit(char[][] maze, int[] entrance)
    {
        const char empty = '.';
        const char visited = '!';
        int m = maze.Length - 1;
        int n = maze[0].Length - 1;
        int x = entrance[0];
        int y = entrance[1];

        Queue<MazePoint> queue = new();

        maze[x][y] = visited;
        int offset = x - 1;
        if (offset >= 0 && offset <= m && maze[offset][y] == empty)
        {
            maze[offset][y] = visited;
            queue.Enqueue(new() { X = offset, Y = y, Value = 1 });
        }
        offset = x + 1;
        if (offset >= 0 && offset <= m && maze[offset][y] == empty)
        {
            maze[offset][y] = visited;
            queue.Enqueue(new() { X = offset, Y = y, Value = 1 });
        }
        offset = y - 1;
        if (offset >= 0 && offset <= n && maze[x][offset] == empty)
        {
            maze[x][offset] = visited;
            queue.Enqueue(new() { X = x, Y = offset, Value = 1 });
        }
        offset = y + 1;
        if (offset >= 0 && offset <= n && maze[x][offset] == empty)
        {
            maze[x][offset] = visited;
            queue.Enqueue(new() { X = x, Y = offset, Value = 1 });
        }

        while (queue.TryDequeue(out MazePoint point))
        {
            if (point.X == 0 || point.X == m || point.Y == 0 || point.Y == n)
                return point.Value;

            int val = point.Value + 1;
            if (maze[point.X - 1][point.Y] == empty)
            {
                maze[point.X - 1][point.Y] = visited;
                queue.Enqueue(new() { X = point.X - 1, Y = point.Y, Value = val });
            }

            if (maze[point.X + 1][point.Y] == empty)
            {
                maze[point.X + 1][point.Y] = visited;
                queue.Enqueue(new() { X = point.X + 1, Y = point.Y, Value = val });
            }

            if (maze[point.X][point.Y - 1] == empty)
            {
                maze[point.X][point.Y - 1] = visited;
                queue.Enqueue(new() { X = point.X, Y = point.Y - 1, Value = val });
            }

            if (maze[point.X][point.Y + 1] == empty)
            {
                maze[point.X][point.Y + 1] = visited;
                queue.Enqueue(new() { X = point.X, Y = point.Y + 1, Value = val });
            }
        }
        return -1;
    }

    private struct MazePoint
    {
        public int X;
        public int Y;
        public int Value;
    }
}