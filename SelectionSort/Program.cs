using SequentialAccessCollections;

namespace SelectionSort;
class Program
{
    static void Main(string[] args)
    {
        Collection numbers = new();
        Random random = new(100);

        for (int i = 0; i <= 10; i++)
        {
            numbers.Add((int)(random.NextDouble() * 100));
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
