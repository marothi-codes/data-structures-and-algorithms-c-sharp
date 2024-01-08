using Random = CustomRandomNumberGenerator.Random;
using SequentialAccessCollections;

namespace RecursiveBinarySearch;
class Program
{
    static void Main(string[] args)
    {
        Collection numbers = new();

        for (int i = 0; i <= 10; i++)
            numbers.Add(Random.NextInt32(0, 50));

        numbers.QuickSort();

        foreach (object number in numbers)
            Console.WriteLine(number);

        int valueToFind = Random.NextInt32(0, 50);

        Console.WriteLine($"Searching for value: {valueToFind}");

        int result = numbers.RecursiveBinarySearch(valueToFind, 0, numbers.Count() - 1);

        Console.WriteLine(result == -1 ? "Not found" : "Found!");
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();

    }
}
