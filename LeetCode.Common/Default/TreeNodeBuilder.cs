namespace LeetCode.Common.Default;

public static class TreeNodeBuilder
{
    /// <summary>
    /// Создает бинарное дерево, <b>null</b> указывает на отсутствие узла
    /// </summary>
    /// <param name="collection">Коллекция значений узлов</param>
    /// <returns><see cref="TreeNode?"/></returns>
    public static TreeNode? FromCollection(ICollection<int?> collection)
    {
        if (collection == null || collection.Count == 0)
            return null;

        IEnumerator<int?> enumerator = collection.GetEnumerator();
        enumerator.MoveNext();

        if (enumerator.Current is null)
            return null;

        TreeNode root = new(enumerator.Current.Value);
        Dictionary<int, TreeNode> nodes = new() { { 0, root } };
        HashSet<int> skip = new();

        int index = 1;
        bool isEven = false;
        while (enumerator.MoveNext())
        {
            if (enumerator.Current is not null)
            {
                TreeNode current = new(enumerator.Current.Value);
                nodes.Add(index, current);

                if (isEven)
                {
                    int parentIndex = (index - 2) / 2;
                    nodes.TryGetValue(parentIndex, out TreeNode? parent);
                    if (parent is not null)
                        parent.right = current;
                }
                else
                {
                    int parentIndex = (index - 1) / 2;
                    nodes.TryGetValue(parentIndex, out TreeNode? parent);
                    if (parent is not null)
                        parent.left = current;
                }
            }
            else
                skip.Add(index);

            if (skip.Contains(index / 2))
                index += 2;

            index++;
            isEven = !isEven;
        }

        return root;
    }
}