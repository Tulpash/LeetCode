// 1028.Recover a Tree From Preorder Traversal
// https://leetcode.com/problems/recover-a-tree-from-preorder-traversal/description/

// We run a preorder depth-first search (DFS) on the root of a binary tree.
// At each node in this traversal, we output D dashes (where D is the depth of this node), then we output the value of this node.  If the depth of a node is D, the depth of its immediate child is D + 1.  The depth of the root node is 0.
// If a node has only one child, that child is guaranteed to be the left child.
// Given the output traversal of this traversal, recover the tree and return its root.

using LeetCode.Common.Default;
using System.Text;

namespace LeetCode.Tasks.Hard.LC1028;

public class Solution
{
    int index;
    string nodes = null!;

    public TreeNode? RecoverFromPreorder(string traversal)
    {
        index = 0;
        nodes = traversal;
        return Recover(0);
    }

    private TreeNode? Recover(int priority)
    {
        int oldIndex = index;
        var (prior, val) = NextNode();

        if (priority > prior)
        {
            index = oldIndex;
            return null;
        }

        TreeNode root = new TreeNode(val);
        root.left = Recover(priority + 1);
        root.right = Recover(priority + 1);
        return root;
    }

    private (int, int) NextNode()
    {
        int prior = 0;
        StringBuilder builder = new StringBuilder("0");
        while (index < nodes.Length && nodes[index] == '-')
        {
            prior++;
            index++;
        }
        while (index < nodes.Length && nodes[index] != '-')
        {
            builder.Append(nodes[index]);
            index++;
        }
        return (prior, Convert.ToInt32(builder.ToString()));
    }
}