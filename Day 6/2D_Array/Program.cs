using System;

namespace _2D_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // animal2DArray ();
            int2DArray();
        }

        private static void animal2DArray () {
            // ... Create 2D array string
            string [,] array = new string [,] {
                {"cat", "dog"},
                {"bird", "fish"}
            };

            Console.WriteLine ("length method: {0}", array.Length);
            Console.WriteLine("GetUpperBound: {0}", array.GetUpperBound(1));

            Console.WriteLine(array[0, 0]);
            Console.WriteLine(array[0, 1]);
            Console.WriteLine(array[1, 0]);
            Console.WriteLine(array[1, 1]);
        }

        private static void int2DArray () {
            int [,] codes = new int [,] {
                {200, 400},
                {2000, 4176},
                {20000, 40000}
            };

            Console.WriteLine("GetUpperBound: {0}", codes.GetUpperBound(0));
            Console.WriteLine("GetUpperBound: {0}", codes.GetUpperBound(1));
            Console.WriteLine("Rank: {0}", codes.Rank);
        }
    }
}
