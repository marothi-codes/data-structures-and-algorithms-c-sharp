namespace SequentialAccessCollections;

class Program
{
    static void Main(string[] args)
    {

        // Declare and initialise a collection
        Collection courses = new()
        {
            "JavaScript",
            "TypeScript",
            ".Net",
            "Angular",
            "Azure DevOps",
            "PHP",
            "Python",
            "Rust"
        };

        // Print each collecton item in the console
        foreach (var course in courses)
        {
            Console.WriteLine(course);
        }

        // Print the number of items in the collection
        Console.WriteLine($"Number of courses: {courses.Count()}");

        // Remove 1 item from the collection
        courses.Remove("PHP");

        // Print the number of items in the collection
        Console.WriteLine($"Number of courses remaining: {courses.Count()}");

        // Empty the collection
        courses.Clear();

        // Print the number of items in the collection
        Console.WriteLine($"Number of courses remaining: {courses.Count()}");

        // Prompt the user to press any key to exit and await input
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();

    }
}
