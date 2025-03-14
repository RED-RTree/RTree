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

    public bool Contains(T value)
    {
        throw new NotImplementedException();
    }

    public void Delete(T value)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<T> TraverseInOrder()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<T> TraversePreOrder()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<T> TraversePostOrder()
    {
        throw new NotImplementedException();
    }
}
