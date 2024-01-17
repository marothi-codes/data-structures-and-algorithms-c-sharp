#nullable disable

namespace PasswordValidator;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a complex password");
        string password = Console.ReadLine();

        if (IsPasswordNullOrEmpty(password))
        {
            Console.WriteLine("The password is required, an empty password or space character is not acceptable.");
        }
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
        return password.Any(char.IsUpper) && // Uppercase check
            password.Any(char.IsLower) && // Lowercase check
            password.Any(char.IsLetterOrDigit) && // Alphanumeric char check
            password.Any(char.IsAscii); // Special char check
    }

    static bool IsPasswordNullOrEmpty(string password)
    {
        return string.IsNullOrEmpty(password) || string.IsNullOrWhiteSpace(password);
    }
}
