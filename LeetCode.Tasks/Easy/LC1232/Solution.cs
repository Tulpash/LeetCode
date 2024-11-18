// 1232.Check If It Is a Straight Line
// https://leetcode.com/problems/check-if-it-is-a-straight-line/description/

// You are given an array coordinates, coordinates[i] = [x, y], where[x, y] represents the coordinate of a point. Check if these points make a straight line in the XY plane.

namespace LeetCode.Tasks.Easy.LC1232;

public class Solution
{
    public bool CheckStraightLine(int[][] coordinates)
    {
        if (coordinates.Length == 2)
            return true;
        var (x1, y1) = (coordinates[0][0], coordinates[0][1]);
        var (x2, y2) = (coordinates[1][0], coordinates[1][1]);
        for (int i = 2; i < coordinates.Length; i++)
        {
            var (x, y) = (coordinates[i][0], coordinates[i][1]);
            if ((x - x1) * (y2 - y1) != (y - y1) * (x2 - x1))
                return false;
        }
        return true;
    }
}