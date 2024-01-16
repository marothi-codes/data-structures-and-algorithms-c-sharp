namespace FindMaxNum;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 0, 18, 92, 1024, 2048, 101024, 128 };

        Console.WriteLine("Finding max int...");

        int max = FindMax(numbers);

        Console.WriteLine($"The highest int is: {max}");
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    static int FindMax(int[] numbers)
    {
        int reference = numbers[0];

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > reference)
                reference = numbers[i];
        }

        return reference;
    }
}
