﻿using SequentialAccessCollections;

namespace BubbleSort;
class Program
{
    static void Main(string[] args)
    {
        Collection numbers = new();

        for (int i = 0; i <= 10; i++)
            numbers.Add((int)(CustomRandomNumberGenerator.Random.NextDouble() * 100));

        foreach (object number in numbers)
            Console.WriteLine(number);

        numbers.BubbleSort(); // Bubble sort is the slowest sorting algorithm.
        Console.WriteLine("____________________________________________");

        foreach (object number in numbers)
            Console.WriteLine(number);

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
