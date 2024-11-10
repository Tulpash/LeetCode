// 239.Sliding Window Maximum
// https://leetcode.com/problems/sliding-window-maximum/

//You are given an array of integers nums, there is a sliding window of size k which is moving from the very left of the array to the very right. You can only see the k numbers in the window. Each time the sliding window moves right by one position.
//Return the max sliding window.

namespace LeetCode.Tasks.Hard.LC239;

public class Solution
{
    public int[] MaxSlidingWindow(int[] nums, int k)
    {
        int[] res = new int[nums.Length - k + 1];
        int index = 0;
        Deque<int> deque = new();
        int left = 0;
        int right = 0;
        while (right < nums.Length)
        {
            while (deque.Count > 0 && nums[right] > deque.PeekFront())
            {
                deque.PopFront();
            }
            deque.PushFront(nums[right]);
            if (right - left + 1 == k)
            {
                res[index] = deque.PeekBack();
                index++;
                if (deque.PeekBack() == nums[left])
                {
                    deque.PopBack();
                }
                left++;
            }
            right++;
        }
        return res;
    }
}

public class Deque<T>
{
    private List<T> _list;

    public Deque(int size = 16)
    {
        _list = new(size);
    }

    public int Count => _list.Count;

    public void PushFront(T item)
    {
        _list.Add(item);
    }

    public T PeekFront()
    {
        return _list[_list.Count - 1];
    }

    public T PopFront()
    {
        T tmp = _list[_list.Count - 1];
        _list.RemoveAt(_list.Count - 1);
        return tmp;
    }

    public void PushBack(T item)
    {
        _list.Insert(0, item);
    }

    public T PeekBack()
    {
        return _list[0];
    }

    public T PopBack()
    {
        T tmp = _list[0];
        _list.RemoveAt(0);
        return tmp;
    }
}