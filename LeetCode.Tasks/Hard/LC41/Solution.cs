// 41.First Missing Positive
// https://leetcode.com/problems/first-missing-positive/description/

// Given an unsorted integer array nums. Return the smallest positive integer that is not present in nums.

namespace LeetCode.Tasks.Hard.LC41;

public class Solution
{
    public int FirstMissingPositive(int[] nums)
    {
        nums = nums.Distinct().ToArray();
        Array.Sort(nums);
        int current = 1;
        foreach (int num in nums)
        {
            if (num <= 0)
                continue;

            if (num == current)
                current++;
            else
                break;
        }
        return current;
    }
}