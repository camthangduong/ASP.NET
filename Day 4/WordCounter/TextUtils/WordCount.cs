using System;
using System.Linq;

namespace TextUtils
{
    public static class WordCount
    {
        public static int GetWordCount (string searchWord, string inputString) 
        {
            // Null check these variables and determine if they have values
            if (String.IsNullOrEmpty(searchWord) || String.IsNullOrEmpty(inputString))
            {
                return 0;
            }
            // Convert the string into an array of words
            var source = inputString.Split(new char [] {'.', '?', '!', ' ', ';', ':', ','}, StringSplitOptions.RemoveEmptyEntries);
            // Create the query. Use ToLowerINvariant to match uppercase/lowercase
            var matchQuery = from word in source
                         where word.ToLowerInvariant() == searchWord.ToLowerInvariant()
                         select word;
            // Count the matches, which executes the query. Return the result
            return matchQuery.Count();
        }
    }
}
