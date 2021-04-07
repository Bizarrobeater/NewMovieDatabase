using System;
using System.IO;
using NewMovieDatabase;
using NewMovieDatabase.SQLBuilder;


namespace ConsoleForTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            string testDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string baseDirectory = Directory.GetParent(testDirectory).Parent.Parent.Parent.Parent.FullName;

            
            Console.WriteLine(testDirectory);
            Console.WriteLine(baseDirectory);
        }

        //public static void TestEscapeCharacters()
        //{
        //    string testString = "Es'cap'e";
        //    string expected = @"LIKE '%Es''cap''e%'";

        //    ISearchParameter search = new TextParamInclude(testString);
        //    Console.WriteLine($"Expected: {expected}\nActual: {search.ReturnAsSQLParameter}");
        //}

        //public static void TestRemoveQuotes()
        //{
        //    string testString = "\"Quotes Test\"";
        //    string expected = @"LIKE '%Quotes Test%'";

        //    ISearchParameter search = new TextParamInclude(testString);
        //    Console.WriteLine($"Expected: {expected}\nActual: {search.ReturnAsSQLParameter}");        
        //}

        public static void TestDateTimeCompare()
        {
            DateTime first = DateTime.Parse("01-01-2010");
            DateTime second = DateTime.Parse("01-01-2020");

            Console.WriteLine(first.CompareTo(second));
            Console.WriteLine(second.CompareTo(first));
            Console.WriteLine(first.CompareTo(first));
        }

        public static void TestDateAsParamImplicit()
        {
            DateAsParam test = new DateAsParam("2020-01-01");
            
            DateTime before = DateTime.Parse("2019-01-01");
            DateTime after = DateTime.Parse("2021-01-01");
            DateTime same = DateTime.Parse("2020-01-01");
        }
    }
}
