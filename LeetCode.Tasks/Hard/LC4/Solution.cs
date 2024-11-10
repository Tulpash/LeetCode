// 4.Median of Two Sorted Arrays
// https://leetcode.com/problems/median-of-two-sorted-arrays/description/

// Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.

namespace LeetCode.Tasks.Hard.LC4;

public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int[] set = new int[nums1.Length + nums2.Length];
        Array.Copy(nums1, set, nums1.Length);
        Array.Copy(nums2, 0, set, nums1.Length, nums2.Length);
        Span<int> span = set;
        span.Sort();
        if (span.Length % 2 == 0)
        {
            int mid = span.Length / 2;
            return (span[mid] + span[mid - 1]) / 2d;
        }
        else
        {
            return span[span.Length / 2];
        }
    }
}