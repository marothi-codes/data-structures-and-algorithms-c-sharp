namespace LinkedList;
class Program
{
    static void Main(string[] args)
    {
        LinkedList<string> linkedList = new LinkedList<string>();

        // Adding elements to the LinkedList
        linkedList.AddFirst("Marothi");
        linkedList.AddLast("Bob");
        linkedList.AddAt(1, "Charlie");

        // Printing all nodes
        Console.WriteLine("All nodes in the LinkedList:");
        linkedList.PrintAllNodes();

        // Finding a node
        var node = linkedList.Find("Charlie");

        if (node != null)
        {
            Console.WriteLine($"Found node with value: {node.Value}");
        }

        // Accessing a node by index
        Console.WriteLine($"Value at index 1: {linkedList.Get(1)}");

        // Removing a node
        linkedList.Remove("Charlie");
        Console.WriteLine("All nodes in the LinkedList after removing 'Charlie':");
        linkedList.PrintAllNodes();

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
