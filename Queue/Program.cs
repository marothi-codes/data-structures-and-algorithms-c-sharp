using Random = CustomRandomNumberGenerator.Random;

namespace Queue;

class Program
{
    static void Main(string[] args)
    {
        Queue<int> queue = new();

        // ENQUEUE
        for (int i = 0; i < 5; i++)
            queue.Enqueue(Random.NextInt32(0, 35));

        Console.WriteLine("Queue after enqueueing");
        queue.PrintQueue();
        Console.WriteLine($"Items in queue: {queue.Count()}");

        // DEQUEUE
        queue.Dequeue();
        Console.WriteLine("Queue after dequeueing");
        queue.PrintQueue();
        Console.WriteLine($"Remaining items in the queue: {queue.Count()}");

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
