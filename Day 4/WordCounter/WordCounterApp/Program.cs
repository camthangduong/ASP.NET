using System;
using TextUtils;

namespace WordCounterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter search word: ");
            var searchWord = Console.ReadLine();
            Console.WriteLine("Provide the string to search: ");
            var inputString = Console.ReadLine();

            var wordCount = WordCount.GetWordCount(searchWord, inputString);

            var pluralChar = "s";
            if (wordCount == 1) 
            {
                pluralChar = string.Empty;
            }
            Console.WriteLine($"The search word {searchWord} appears " + $"{wordCount} time{pluralChar}.");
        }
    }
}
