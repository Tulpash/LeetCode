// 124.Binary Tree Maximum Path Sum
// https://leetcode.com/problems/binary-tree-maximum-path-sum/description/

// A path in a binary tree is a sequence of nodes where each pair of adjacent nodes in the sequence has an edge connecting them. A node can only appear in the sequence at most once. Note that the path does not need to pass through the root.
// The path sum of a path is the sum of the node's values in the path.
// Given the root of a binary tree, return the maximum path sum of any non-empty path.

using LeetCode.Common.Default.Tree;

namespace LeetCode.Tasks.Hard.LC124;

public class Solution
{
    private int max = Int32.MinValue;

    public int MaxPathSum(TreeNode? root)
    {
        MaxPathSubtree(root);
        return max;
    }

    private int MaxPathSubtree(TreeNode? root)
    {
        if (root == null)
            return 0;

        int left = Math.Max(MaxPathSubtree(root.left), 0);
        int right = Math.Max(MaxPathSubtree(root.right), 0);
        max = Math.Max(max, left + right + root.val);
        return Math.Max(left + root.val, right + root.val);
    }
}