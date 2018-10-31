using System;
using System.Text.RegularExpressions;

namespace RegExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"\d+");
            Match match = regex.Match("Dot 55 Perls");

            if (match.Success) {
                Console.WriteLine(match.Value);
            }

            // First we see the iunput string
            string input = "/content/alternative-1.aspx";
            Console.WriteLine(input);

            // Here we call Regex.Match
            Match matched = Regex.Match(input, @"content/([A-Za-z0-9\-]+)\.aspx$", RegexOptions.IgnoreCase);

            // Here we check the Match instance
            if (match.Success) {
                // Finally we ge the group value and display it
                string key = matched.Groups[1].Value;
                Console.WriteLine(key);
            }

            string value = "4 AND 5";
            match = Regex.Match(value, @"\d");
            if (match.Success) {
                Console.WriteLine(match.Value);
            }
            match = match.NextMatch();
            if (match.Success) {
                Console.WriteLine(match.Value);
            }
        }
    }
}
