namespace Algorithms.Structures.BinaryTree;

public class Main
{
    public static void _Main()
    {
        var tree = new BinaryTree();

        /* Sample data insertion */
        tree.Insert(50);
        tree.Insert(30);
        tree.Insert(20);
        tree.Insert(40);
        tree.Insert(70);
        tree.Insert(60);
        tree.Insert(80);
        tree.Insert(50); // Duplicate value

        // Print traversals of the tree
        Console.WriteLine("In-order traversal:");
        tree.InOrderTraversal(tree.Root);

        Console.WriteLine("\nPre-order traversal:");
        tree.PreOrderTraversal(tree.Root);

        Console.WriteLine("\nPost-order traversal:");
        tree.PostOrderTraversal(tree.Root);
    }
}