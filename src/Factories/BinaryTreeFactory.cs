using RTree.Implementations;
using RTree.Interfaces;
using RTree.Literals;

namespace RTree.Factories;

public static class BinaryTreeFactory
{
    public static IBinaryTree<T> CreateBinaryTree<T>(
            DuplicateHandling duplicateHandling = DuplicateHandling.None) where T : IComparable<T>
    {
        return new BinaryTree<T>(duplicateHandling);
    }


}
