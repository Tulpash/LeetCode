// 1402.Reducing Dishes
// https://leetcode.com/problems/reducing-dishes/description/

// A chef has collected data on the satisfaction level of his n dishes. Chef can cook any dish in 1 unit of time.
// Like-time coefficient of a dish is defined as the time taken to cook that dish including previous dishes multiplied by its satisfaction level i.e. time[i] * satisfaction[i].
// Return the maximum sum of like-time coefficient that the chef can obtain after preparing some amount of dishes.
// Dishes can be prepared in any order and the chef can discard some dishes to get this maximum value.A chef has collected data on the satisfaction level of his n dishes. Chef can cook any dish in 1 unit of time.
// Like-time coefficient of a dish is defined as the time taken to cook that dish including previous dishes multiplied by its satisfaction level i.e. time[i] * satisfaction[i].
// Return the maximum sum of like-time coefficient that the chef can obtain after preparing some amount of dishes.
// Dishes can be prepared in any order and the chef can discard some dishes to get this maximum value.

namespace LeetCode.Tasks.Hard.LC1402;

public class Solution
{
    public int MaxSatisfaction(int[] satisfaction)
    {
        int res = int.MinValue;
        Array.Sort(satisfaction);
        for (int i = 0; i < satisfaction.Length; i++)
        {
            int tmp = Sum(satisfaction, i);
            if (tmp > res)
                res = tmp;
            if (tmp < res)
                return res;
        }
        return res < 0 ? 0 : res;
    }

    private int Sum(int[] arr, int start)
    {
        int sum = 0;
        int count = 1;
        for (int i = start; i < arr.Length; i++)
        {
            sum += arr[i] * count;
            count++;
        }
        return sum;
    }
}