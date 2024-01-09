namespace HashTable;

class Program
{
    static void Main(string[] args)
    {
        HashTable<string, string> hashTable = new(10);

        // Adding key-value pairs to the hash table
        hashTable.Add("Marothi", "Software Engineer");
        hashTable.Add("Bob", "Data Scientist");
        hashTable.Add("Charlie", "Product Manager");

        // Getting values from the hash table
        Console.WriteLine(hashTable.Get("Marothi")); // Output: Software Engineer
        Console.WriteLine(hashTable.Get("Bob")); // Output: Data Scientist
        Console.WriteLine(hashTable.Get("Charlie")); // Output: Product Manager

        Console.WriteLine("Printing the hash table...");

        hashTable.PrintHashTable();

        // Removing a key-value pair from the hash table
        Console.WriteLine("Removing 'Marothi' from the hash table");
        hashTable.Remove("Marothi");

        Console.WriteLine("Printing the hash table...");

        hashTable.PrintHashTable();

        // Trying to get a value for a key that has been removed
        Console.WriteLine(hashTable.Get("Marothi")); // Output: null

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
