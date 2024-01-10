namespace BinaryTree;
class Program
{
    static void Main(string[] args)
    {
        BinarySearchTree<int> bst = new();

        // Inserting values into the BST
        bst.Insert(50);
        bst.Insert(30);
        bst.Insert(20);
        bst.Insert(40);
        bst.Insert(70);
        bst.Insert(60);
        bst.Insert(80);

        Console.WriteLine("In-Order Traversal of the BST:");
        bst.TraverseInOrder();  // Output: 20 30 40 50 60 70 80

        // Searching for a value in the BST
        Console.WriteLine($"Search for 40: {bst.Search(40)}");  // Output: True
        Console.WriteLine($"Search for 100: {bst.Search(100)}");  // Output: False

        // Deleting a value from the BST
        bst.Delete(20);

        Console.WriteLine("In-Order Traversal of the BST after deleting 20:");
        bst.TraverseInOrder();  // Output: 30 40 50 60 70 80

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
