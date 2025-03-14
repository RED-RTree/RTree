using RTree.Implementations;
using RTree.Interfaces;

namespace RTree.Factories;

public static class BinaryTreeFactory
{
    public static IBinaryTree<T> CreateBinaryTree<T>() where T : IComparable<T> =>
         new BinaryTree<T>();

}
