using Random = CustomRandomNumberGenerator.Random;
using SequentialAccessCollections;

namespace SequentialSearch;

class Program
{
    static void Main(string[] args)
    {
        Collection numbers = new();

        for (int i = 0; i <= 10; i++)
            numbers.Add((int)(Random.NextDouble() * 100));

        foreach (object number in numbers)
            Console.WriteLine(number);

        int valueToFind = (Random.NextInt32() * 1 / 100000000);

        Console.WriteLine($"Searching for: {valueToFind}");

        var result = numbers.SequentialSearch(valueToFind);

        Console.WriteLine(result ? "value found" : "value not found");
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
