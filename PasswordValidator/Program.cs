#nullable disable

namespace PasswordValidator;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a complex password");
        string password = Console.ReadLine();

        if (IsPasswordNullOrEmpty(password))
            Console.WriteLine("The password is required");
        else if (password.Length < 8)
        {
            Console.WriteLine("Your password needs to be 8 characters or longer.");
        }
        else if (IsPasswordValid(password))
        {
            Console.WriteLine("The password is valid as contains letters, numbers and special characters. Well Done!");
        }
        else
        {
            Console.WriteLine("Your password is not complex enough...");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    static bool IsPasswordValid(string password)
    {
        return password.Any(char.IsUpper) &&
            password.Any(char.IsLower) &&
            password.Any(char.IsLetterOrDigit) &&
            password.Any(char.IsSymbol);
    }

    static bool IsPasswordNullOrEmpty(string password)
    {

        return string.IsNullOrEmpty(password) || string.IsNullOrWhiteSpace(password);
    }
}
