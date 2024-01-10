namespace Sets;
class Program
{
    static void Main(string[] args)
    {
        Set<int> set = new();

        // Adding elements to the Set
        set.Add(1);
        set.Add(2);
        set.Add(3);

        // Printing all elements in the Set
        Console.WriteLine("All elements in the Set:");
        foreach (var item in set.Enumerate())
        {
            Console.WriteLine(item);
        }

        // Checking if an element exists in the Set
        Console.WriteLine($"Set contains 2: {set.Contains(2)}");  // Output: True
        Console.WriteLine($"Set contains 4: {set.Contains(4)}");  // Output: False

        // Removing an element from the Set
        set.Remove(2);

        // Printing all elements in the Set after removing 2
        Console.WriteLine("All elements in the Set after removing 2:");
        foreach (var item in set.Enumerate())
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
