using System.Runtime.ExceptionServices;
using Random = CustomRandomNumberGenerator.Random;

namespace Stack;

class Program
{
    static void Main(string[] args)
    {
        Stack<int> stack = new();

        for (int i = 0; i < 10; i++)
            stack.Push(Random.NextInt32(0, 30));

        Console.WriteLine("The untouched stack");
        stack.PrintStack();

        // COUNT
        Console.WriteLine("Checking the number of items in the stack...");
        Console.WriteLine(stack.Count());

        // POP
        Console.WriteLine("Popping the stack...");
        stack.Pop();

        Console.WriteLine("The stack after popping");
        stack.PrintStack();

        // COUNT
        Console.WriteLine("Checking the number of items in the stack...");
        Console.WriteLine(stack.Count());

        // PEEK
        Console.WriteLine("Peeking the stack...");
        Console.WriteLine(stack.Peek());

        // IS EMPTY
        Console.WriteLine("Checking if the stack is empty...");
        Console.WriteLine(stack.IsEmpty());

        // CLEAR
        Console.WriteLine("Clearing the stack...");
        stack.Clear();

        Console.WriteLine("Checking the number of items in the stack...");
        Console.WriteLine(stack.Count());

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
