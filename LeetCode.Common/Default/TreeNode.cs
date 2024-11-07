namespace LeetCode.Common.Default;

public class TreeNode
{
    public int val;
    public TreeNode? left;
    public TreeNode? right;

    public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(
            val,
            left != null ? left.GetHashCode() : 0,
            left != null ? left.GetHashCode() : 0);
    }

    public override bool Equals(object? other) => Equals(other as TreeNode);

    public bool Equals(TreeNode? other) => Equals(this, other);

    public static bool Equals(TreeNode? first, TreeNode? second)
    {
        bool allIsNull = first == null && second == null;
        if (allIsNull)
            return true;

        bool allIsNotNull = first != null && second != null;
        if (!allIsNotNull)
            return false;

        if (first.val != second.val)
            return false;

        return Equals(first.left, second.left) && Equals(first.right, second.right);
    }
}