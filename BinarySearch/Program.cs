using Random = CustomRandomNumberGenerator.Random;
using SequentialAccessCollections;

namespace BinarySearch;

class Program
{
    static void Main(string[] args)
    {
        Collection numbers = new();

        for (int i = 0; i <= 10; i++)
            numbers.Add((int)Random.NextDouble(0, 45));

        int valueToFind = Random.NextInt32(0, 45);

        numbers.QuickSort();

        foreach (object number in numbers)
            Console.WriteLine(number);

        Console.WriteLine($"Searching for value: {valueToFind}");

        var result = numbers.BinarySearch(valueToFind);

        Console.WriteLine(result == -1 ? "Not found" : "Found!");
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();

    }
}
