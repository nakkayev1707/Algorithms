namespace Algorithms.Structures.BinaryTree;

public class Node
{
    public int Data;
    public Node Left;
    public Node Right;
    
    public Node(int data)
    {
        Left = null;
        Right = null;
        Data = data;
    }
}