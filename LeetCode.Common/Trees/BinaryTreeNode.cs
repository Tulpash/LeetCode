namespace LeetCode.Common.Trees;

public class BinaryTreeNode<TValue>
{
    public TValue Value;
    public BinaryTreeNode<TValue>? Left;
    public BinaryTreeNode<TValue>? Right;

    public BinaryTreeNode(TValue value = default!, BinaryTreeNode<TValue>? left = null, BinaryTreeNode<TValue>? right = null)
    {
        Value = value;
        Left = left;    
        Right = right;
    }
}