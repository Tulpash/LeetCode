// 42.Trapping Rain Water
// https://leetcode.com/problems/trapping-rain-water/

// Given n non-negative integers representing an elevation map where the width of each bar is 1, compute how much water it can trap after raining.

namespace LeetCode.Tasks.Hard.LC42;

public class Solution
{
    public int Trap(int[] height)
    {
        int res = 0;
        int pivot = Array.IndexOf(height, height.Max());
        int left = 0;
        int right = left + 1;
        while (right <= pivot)
        {
            if (height[left] == 0)
            {
                left++;
                right++;
            }
            else if (height[right] >= height[left])
            {
                res += height[left] * (right - left - 1);
                for (int i = (left + 1); i < right; i++)
                    res -= height[i];
                left = right;
                right++;
            }
            else
                right++;
        }
        right = height.Length - 1;
        left = right - 1;
        while (left >= pivot)
        {
            if (height[right] == 0)
            {
                left--;
                right--;
            }
            else if (height[left] >= height[right])
            {
                res += height[right] * (right - left - 1);
                for (int i = (right - 1); i > left; i--)
                    res -= height[i];
                right = left;
                left--;
            }
            else
                left--;
        }
        return res;
    }
}