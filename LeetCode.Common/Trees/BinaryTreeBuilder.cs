namespace LeetCode.Common.Trees;

public static class BinaryTreeBuilder
{
    /// <summary>
    /// Создает бинарное дерево на основе коллекции структур, <b>null</b> указывает на отсутствие узла
    /// </summary>
    /// <typeparam name="TValue">Тип значения узла дерева</typeparam>
    /// <param name="collection">Коллекция значений узлов</param>
    /// <returns><see cref="BinaryTreeNode{TValue}"/></returns>
    public static BinaryTreeNode<TValue>? FromCollection<TValue>(ICollection<Nullable<TValue>> collection) where TValue : struct
    {
        if (collection == null || collection.Count == 0)
            return null;

        IEnumerator<Nullable<TValue>> enumerator = collection.GetEnumerator();
        enumerator.MoveNext();

        if (enumerator.Current is null)
            return null;

        BinaryTreeNode<TValue> root = new(enumerator.Current.Value);
        Dictionary<int, BinaryTreeNode<TValue>> nodes = new() { { 0, root } };
        
        int index = 1;
        bool isEven = false;
        while (enumerator.MoveNext()) 
        {
            if (enumerator.Current is not null)
            {
                BinaryTreeNode<TValue> current = new(enumerator.Current.Value);
                nodes.Add(index, current);

                if (isEven)
                {
                    int parentIndex = (index - 2) / 2;
                    nodes.TryGetValue(parentIndex, out BinaryTreeNode<TValue>? parent);
                    if (parent is not null)
                        parent.Right = current;
                }
                else
                {
                    int parentIndex = (index - 1) / 2;
                    nodes.TryGetValue(parentIndex, out BinaryTreeNode<TValue>? parent);
                    if (parent is not null)
                        parent.Left = current;
                }    
            }
            index++;
            isEven = !isEven;
        }

        return root;
    }

    /// <summary>
    /// Создает бинарное дерево на основе коллекции ссылочных типов, <b>null</b> указывает на отсутствие узла
    /// </summary>
    /// <typeparam name="TValue">Тип значения узла дерева</typeparam>
    /// <param name="collection">Коллекция значений узлов</param>
    /// <returns><see cref="BinaryTreeNode{TValue}"/></returns>
    public static BinaryTreeNode<TValue>? FromCollection<TValue>(ICollection<TValue> collection) where TValue : class
    {
        if (collection == null || collection.Count == 0)
            return null;

        IEnumerator<TValue> enumerator = collection.GetEnumerator();
        enumerator.MoveNext();

        if (enumerator.Current is null)
            return null;

        BinaryTreeNode<TValue> root = new(enumerator.Current);
        Dictionary<int, BinaryTreeNode<TValue>> nodes = new() { { 0, root } };

        int index = 1;
        bool isEven = false;
        while (enumerator.MoveNext())
        {
            if (enumerator.Current is not null)
            {
                BinaryTreeNode<TValue> current = new(enumerator.Current);
                nodes.Add(index, current);

                if (isEven)
                {
                    int parentIndex = (index - 2) / 2;
                    BinaryTreeNode<TValue> parent = nodes[parentIndex];
                    parent.Right = current;
                }
                else
                {
                    int parentIndex = (index - 1) / 2;
                    BinaryTreeNode<TValue> parent = nodes[parentIndex];
                    parent.Left = current;
                }
            }
            index++;
            isEven = !isEven;
        }

        return root;
    }
}