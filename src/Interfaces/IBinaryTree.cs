namespace RTree.Interfaces;

public interface IBinaryTree<T> where T : IComparable<T>
{
    void Insert(T value);
    bool Contains(T value);
    void Delete(T value);
    IEnumerable<T> TraverseInOrder();
    IEnumerable<T> TraversePreOrder();
    IEnumerable<T> TraversePostOrder();
}
