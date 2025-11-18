namespace RTree.Interfaces;

public interface IBinaryTree<T> : ITree<T> where T : IComparable<T>
{
    IEnumerable<T> TraversePreOrder();
    IEnumerable<T> TraversePostOrder();
}