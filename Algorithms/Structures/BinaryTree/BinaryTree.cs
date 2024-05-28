namespace Algorithms.Structures.BinaryTree;

public class BinaryTree
{
    public Node Root;

    public BinaryTree()
    {
        Root = null;
    }

    public void Insert(int data)
    {
        Root = InsertRec(Root, data);
    }
    
    private Node InsertRec(Node root, int data)
    {
        if (root == null)
        {
            root = new Node(data);
            return root;
        }

        if (data < root.Data)
            root.Left = InsertRec(root.Left, data);
        else if (data > root.Data)
            root.Right = InsertRec(root.Right, data);

        return root;
    }
    
    public void InOrderTraversal(Node root)
    {
        if (root != null)
        {
            InOrderTraversal(root.Left);
            Console.Write(root.Data + " ");
            InOrderTraversal(root.Right);
        }
    }

    // Pre-order traversal
    public void PreOrderTraversal(Node root)
    {
        if (root != null)
        {
            Console.Write(root.Data + " ");
            PreOrderTraversal(root.Left);
            PreOrderTraversal(root.Right);
        }
    }

    // Post-order traversal
    public void PostOrderTraversal(Node root)
    {
        if (root != null)
        {
            PostOrderTraversal(root.Left);
            PostOrderTraversal(root.Right);
            Console.Write(root.Data + " ");
        }
    }
}
