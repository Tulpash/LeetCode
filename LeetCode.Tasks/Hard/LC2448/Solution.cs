// 2448.Minimum Cost to Make Array Equal
// https://leetcode.com/problems/minimum-cost-to-make-array-equal/description/

// You are given two 0-indexed arrays nums and cost consisting each of n positive integers.
// You can do the following operation any number of times:
// Increase or decrease any element of the array nums by 1.
// The cost of doing one operation on the ith element is cost[i].
// Return the minimum total cost such that all the elements of the array nums become equal.You are given two 0-indexed arrays nums and cost consisting each of n positive integers.
// You can do the following operation any number of times:
// Increase or decrease any element of the array nums by 1.
// The cost of doing one operation on the ith element is cost[i].
// Return the minimum total cost such that all the elements of the array nums become equal.

namespace LeetCode.Tasks.Hard.LC2448;

public class Solution
{
    public long MinCost(int[] nums, int[] cost)
    {
        long res = 0;
        int left = int.MaxValue;
        int right = int.MinValue;
        int middle = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            left = Math.Min(nums[i], left);
            right = Math.Max(nums[i], right);
        }

        while (left < right)
        {
            middle = left + (right - left) / 2;
            long current = Cost(nums, cost, middle);
            long next = Cost(nums, cost, middle + 1);
            res = Math.Min(current, next);
            if (current > next)
                left = middle + 1;
            else
                right = middle;
        }

        return res;
    }

    private long Cost(int[] nums, int[] cost, int num)
    {
        long res = 0;
        for (int i = 0; i < nums.Length; i++)
            res += (long)Math.Abs(nums[i] - num) * cost[i];

        return res;
    }
}