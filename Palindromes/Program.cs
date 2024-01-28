#nullable disable

namespace Palindromes;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter a string
        Console.WriteLine("Enter a string to check if it is a palindrome:");
        string input = Console.ReadLine();

        // Call the palindrome method and display the result
        bool result = IsPalindrome(input);
        if (result)
        {
            Console.WriteLine($"'{input}' is a palindrome.");
        }
        else
        {
            Console.WriteLine($"'{input}' is not a palindrome.");
        }

        Console.WriteLine("Press any key to ext...");
        Console.ReadKey();
    }

    public static bool IsPalindrome(string input)
    {
        // Convert the string to lowercase and remove spaces or punctuation
        input = input.ToLower().Replace(" ", "")
            .Replace(",", "")
            .Replace(".", "")
            .Replace("?", "")
            .Replace("!", "");

        // Reverse the string and compare with the original.
        char[] arr = input.ToCharArray();
        Array.Reverse(arr);
        string reversedInput = new string(arr);

        return input == reversedInput;
    }
}
