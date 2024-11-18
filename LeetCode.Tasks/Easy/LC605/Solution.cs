// 605.Can Place Flowers
// https://leetcode.com/problems/can-place-flowers/description/

// You have a long flowerbed in which some of the plots are planted, and some are not. However, flowers cannot be planted in adjacent plots.
// Given an integer array flowerbed containing 0's and 1's, where 0 means empty and 1 means not empty, and an integer n, return true if n new flowers can be planted in the flowerbed without violating the no-adjacent-flowers rule and false otherwise.

namespace LeetCode.Tasks.Easy.LC605;

public class Solution
{
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        int count = 0;
        int i = 0;
        while (i < flowerbed.Length)
        {
            if (flowerbed[i] == 0)
            {
                int index = i + 1 >= flowerbed.Length ? flowerbed.Length - 1 : i + 1;
                if (flowerbed[index] == 0)
                {
                    count++;
                    i += 2;
                }
                else
                    i += 3;
            }
            else
                i += 2;
        }
        return count >= n;
    }
}