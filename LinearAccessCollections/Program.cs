namespace LinearAccessCollections;

class Program
{
    static void Main(string[] args)
    {
        string[] users = { "John", "Matt" };
        Console.WriteLine(users[0]);
        Console.WriteLine(users[1]);

        var myName = new Name("Marothi", "Mabutho", "Mahlake");
        string fullName,
            initials;
        fullName = myName.ToString();
        initials = myName.Initials();

        Console.WriteLine($"My name is {fullName}");
        Console.WriteLine($"My initials are: {initials}");

        int num;
        string? sNum;

        Console.Write("Enter a number");
        try
        {
            sNum = Console.ReadLine();
            if (!string.IsNullOrEmpty(sNum))
            {
                num = int.Parse(sNum);
                Console.WriteLine($"The number you've entered is: {num}");
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
            else
            {
                throw new ArgumentNullException();
            }
        }
        catch (ArgumentNullException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

public struct Name
{
    private string fName,
        mName,
        lName;

    public Name(string first, string middle, string last)
    {
        fName = first;
        mName = middle;
        lName = last;
    }

    public string FirstName
    {
        readonly get => fName;
        set => fName = FirstName;
    }

    public string MiddleName
    {
        readonly get => mName;
        set => mName = MiddleName;
    }

    public string LastName
    {
        readonly get => lName;
        set => lName = LastName;
    }

    public override readonly string ToString()
    {
        return $"{fName} {mName} {lName}";
    }

    public readonly string Initials()
    {
        return $"{fName[..1]} {mName[..1]} {lName[..1]}";
    }
}
