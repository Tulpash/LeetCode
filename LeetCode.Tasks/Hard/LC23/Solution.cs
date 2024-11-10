// 23.Merge k Sorted Lists
// https://leetcode.com/problems/merge-k-sorted-lists/description/

// You are given an array of k linked-lists lists, each linked-list is sorted in ascending order.
// Merge all the linked-lists into one sorted linked-list and return it.

using LeetCode.Common.Default.List;

namespace LeetCode.Tasks.Hard.LC23;

public class Solution
{
    public ListNode? MergeKLists(ListNode[]? lists)
    {
        if (lists == null || lists.Length == 0)
            return null;

        lists = lists.Where(list => list != null).ToArray();
        if (lists.Length == 0)
            return null;

        ListNode res = lists[0];

        for (int i = 1; i < lists.Length; i++)
        {
            ListNode? node = lists[i];
            while (node != null)
            {
                ListNode tmp = res;
                while (tmp != null)
                {
                    if (node.val < tmp.val)
                    {
                        res = new ListNode(node.val, tmp);
                        break;
                    }

                    if (tmp.next == null)
                    {
                        tmp.next = new ListNode(node.val, null);
                        break;
                    }

                    if (node.val >= tmp.val && node.val <= tmp.next.val)
                    {
                        tmp.next = new ListNode(node.val, tmp.next);
                        break;
                    }

                    tmp = tmp.next;
                }
                node = node.next;
            }
        }
        return res;
    }
}