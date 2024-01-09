namespace Dictionary;

class Program
{
    static void Main(string[] args)
    {
        DictionaryImplementation<string, int> myDictionary = new();

        // Add some elements to the dictionary
        myDictionary.Add("Apple", 1);
        myDictionary.Add("Banana", 2);
        myDictionary.Add("Cherry", 3);

        // Print the value associated with "Apple"
        Console.WriteLine("The value associated with 'Apple' is: " + myDictionary["Apple"]);

        // Remove "Banana" from the dictionary
        myDictionary.Remove("Banana");

        // Try to get the value associated with "Banana"
        if (myDictionary.ContainsKey("Banana"))
        {
            Console.WriteLine("The value associated with 'Banana' is: " + myDictionary["Banana"]);
        }
        else
        {
            Console.WriteLine("'Banana' is not in the dictionary");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
