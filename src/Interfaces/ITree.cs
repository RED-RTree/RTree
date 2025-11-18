namespace RTree.Interfaces;

public interface ITree<T> : IEnumerable<T> where T : IComparable<T>
{
    void Insert(T value);
    bool Contains(T value);
    void Delete(T value);
    IEnumerable<T> TraverseInOrder();
}
