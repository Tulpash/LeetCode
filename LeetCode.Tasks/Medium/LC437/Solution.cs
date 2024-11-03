// 437. Path Sum III
// https://leetcode.com/problems/path-sum-iii/description

// Given the root of a binary tree and an integer targetSum, return the number of paths where the sum of the values along the path equals targetSum.
// The path does not need to start or end at the root or a leaf, but it must go downwards (i.e., traveling only from parent nodes to child nodes).

using LeetCode.Common.Trees;

namespace LeetCode.Tasks.Medium.LC437;

public class Solution
{
    public int PathSum(BinaryTreeNode<int>? root, int targetSum)
    {
        if (root is null)
            return 0;

        return DFS(root, targetSum) + PathSum(root.Left, targetSum) + PathSum(root.Right, targetSum);
    }

    private int DFS(BinaryTreeNode<int> node, long targetSum)
    {
        int sum = node.Value == targetSum ? 1 : 0;

        if (node.Left is not null)
            sum += DFS(node.Left, targetSum - node.Value);

        if (node.Right is not null)
            sum += DFS(node.Right, targetSum - node.Value);

        return sum;
    }
}