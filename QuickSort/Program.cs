using Random = CustomRandomNumberGenerator.Random;
using SequentialAccessCollections;

namespace QuickSort;

class Program
{
    static void Main(string[] args)
    {
        Collection numbers = new();

        for (int i = 0; i <= 10; i++)
            numbers.Add((int)(Random.NextDouble() * 100));

        foreach (object number in numbers)
            Console.WriteLine(number);

        Console.WriteLine("_____________________________________________\r\n");

        numbers.QuickSort();

        foreach (object number in numbers)
            Console.WriteLine(number);

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();

    }
}
