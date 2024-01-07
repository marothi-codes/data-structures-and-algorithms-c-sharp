using Random = CustomRandomNumberGenerator.Random;
using SequentialAccessCollections;

namespace ShellSort;

class Program
{
    static void Main(string[] args)
    {
        Collection numbers = new();

        for (int i = 0; i <= 10; i++)
            numbers.Add((int)(Random.NextDouble() * 100));

        foreach (object number in numbers)
            Console.WriteLine(number);

        numbers.ShellSort();

        Console.WriteLine("_______________________________________________\r\n");

        foreach (object number in numbers)
            Console.WriteLine(number);

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();

    }
}
