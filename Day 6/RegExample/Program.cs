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
        }
    }
}
