namespace Anagrams;

class Program
{
    static void Main(string[] args)
    {
        // The original dictionary
        var words = new Dictionary<string, int> { { "earth", 1 }, { "heart", 2 }, { "day", 3 }, { "word", 4 }, { "yad", 3 }, { "art", 5 }, { "rat", 6 }, { "tar", 7 } };

        // Create an array of structures that store the original words and their sorted versions
        var wordArray = new Word[words.Count];
        int i = 0;
        foreach (var pair in words)
        {
            wordArray[i] = new Word();
            wordArray[i].original = pair.Key;
            wordArray[i].sorted = String.Concat(pair.Key.OrderBy(c => c));
            i++;
        }

        // Sort the array by the sorted words
        Array.Sort(wordArray, (a, b) => a.sorted.CompareTo(b.sorted));

        // Print all anagrams detected
        Console.WriteLine("The anagrams detected are:");
        for (i = 0; i < wordArray.Length - 1; i++)
        {
            // Check if the current word and the next word are anagrams
            if (wordArray[i].sorted == wordArray[i + 1].sorted)
            {
                // Print the current word
                Console.Write(wordArray[i].original + " ");

                // Print the next word and increment the index
                Console.Write(wordArray[i + 1].original + " ");
                i++;

                // Check if there are more anagrams in the group and print them
                while (i < wordArray.Length - 1 && wordArray[i].sorted == wordArray[i + 1].sorted)
                {
                    Console.Write(wordArray[i + 1].original + " ");
                    i++;
                }

                // Print a new line after each group of anagrams
                Console.WriteLine();
            }
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}

// A structure to store the original word and its sorted version
public struct Word
{
    public string original;
    public string sorted;
}
