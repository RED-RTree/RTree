using RTree.Interfaces;

namespace RTree.Implementations;

internal class BinaryTree<T> : IBinaryTree<T> where T : IComparable<T>
{
    private class Node(T value)
    {
        public T Value { get; set; } = value;
        public Node? Left { get; set; }
        public Node? Right { get; set; }
    }
    private Node? _root;

    public void Insert(T value) => _root = InsertRec(_root, value);

    private Node InsertRec(Node? node, T value)
    {
        if (node == null)
            return new Node(value);

        if (value.CompareTo(node.Value) < 0)
            node.Left = InsertRec(node.Left, value);
        else if (value.CompareTo(node.Value) > 0)
            node.Right = InsertRec(node.Right, value);

        return node;
    }

    public bool Contains(T value) => ContainsRec(_root, value);

    private bool ContainsRec(Node? node, T value)
    {
        if (node == null)
            return false;

        if (value.CompareTo(node.Value) == 0)
            return true;

        return value.CompareTo(node.Value) < 0
            ? ContainsRec(node.Left, value)
            : ContainsRec(node.Right, value);
    }

    public void Delete(T value) => _root = DeleteRec(_root, value);

    private Node? DeleteRec(Node? node, T value)
    {
        if (node == null)
            return null;

        if (value.CompareTo(node.Value) < 0)
            node.Left = DeleteRec(node.Left, value);
        else if (value.CompareTo(node.Value) > 0)
            node.Right = DeleteRec(node.Right, value);
        else
        {
            if (node.Left == null)
                return node.Right;
            if (node.Right == null)
                return node.Left;

            node.Value = MinValue(node.Right);
            node.Right = DeleteRec(node.Right, node.Value);
        }

        return node;
    }

    private T MinValue(Node node)
    {
        T minValue = node.Value;
        while (node.Left != null)
        {
            minValue = node.Left.Value;
            node = node.Left;
        }
        return minValue;
    }



