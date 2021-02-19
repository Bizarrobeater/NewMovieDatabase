using System;
using NewMovieDatabase.SearchParameters;


namespace ConsoleForTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            TestEscapeCharacters();
        }

        public static void TestEscapeCharacters()
        {
            string testString = "Es'cap'e";
            string expected = @"LIKE '%Es''cap''e%'";

            ISearchParameter search = new TextParamInclude(testString);
            Console.WriteLine($"Expected: {expected}\nActual: {search.ReturnAsSQLParameter}");
        }

        public static void TestRemoveQuotes()
        {
            string testString = "\"Quotes Test\"";
            string expected = @"LIKE '%Quotes Test%'";

            ISearchParameter search = new TextParamInclude(testString);
            Console.WriteLine($"Expected: {expected}\nActual: {search.ReturnAsSQLParameter}");        }
    }
}
