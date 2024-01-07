using SequentialAccessCollections;

namespace SelectionSort;
class Program
{
    static void Main(string[] args)
    {
        Collection numbers = new();

        for (int i = 0; i <= 15; i++)
        {
            numbers.Add((int)(CustomRandomNumberGenerator.Random.NextDouble() * 100));
        }

        foreach (object number in numbers)
            Console.WriteLine(number);

        numbers.SelectionSort();
        Console.WriteLine("_______________________________________________");

        foreach (object number in numbers)
            Console.WriteLine(number);

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();

    }
}
