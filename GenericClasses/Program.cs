namespace GenericClasses;
class Program
{
    static void Main(string[] args)
    {
        LinkedList<string> node1 = new("John", null);
        LinkedList<string> node2 = new("Matt", node1);
        LinkedList<string>? obj = node2.List;

        Console.WriteLine(node1.Data);
        Console.WriteLine(node2.Data);
        Console.WriteLine(obj?.Data);

        Console.ReadKey();
    }

    static void Swap<T>(ref T val1, ref T val2)
    {
        T temp;
        temp = val1;
        val1 = val2;
        val2 = temp;
    }
}
