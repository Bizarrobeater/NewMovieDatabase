using NUnit.Framework;
using NewMovieDatabase.SearchParameters;

namespace TestProject
{
    [TestFixture]
    public class TextParamTests
    {
        string expected;
        ISearchParameter searchParameter;

        [TestCase("TestString")]
        [TestCase("AnotherString")]
        public void TestTextParamExact(string testString)
        {
            expected = $"LIKE '{testString}'";

            searchParameter = new TextParamExact(testString);
            Assert.AreEqual(expected, searchParameter.ReturnAsSQLParameter);
        }

        [TestCase("TestString")]
        [TestCase("AnotherString")]
        public void TestTextParamExclude(string testString)
        {
            expected = $@"NOT LIKE '%{testString}%'";

            searchParameter = new TextParamExclude(testString);
            Assert.AreEqual(expected, searchParameter.ReturnAsSQLParameter);
        }

        [TestCase("TestString")]
        [TestCase("AnotherString")]
        public void TestTextParamInclude(string testString)
        {
            expected = $@"LIKE '%{testString}%'";

            searchParameter = new TextParamInclude(testString);
            Assert.AreEqual(expected, searchParameter.ReturnAsSQLParameter);
        }

        [TestCase("Test'Strin'g")]
        [TestCase("A'notherStrin'g")]
        public void TestEscapeCharacters(string testString)
        {
            string escapedString = new string(testString).Replace("'", "''");
            expected = $@"LIKE '%{escapedString}%'";

            searchParameter = new TextParamInclude(testString);
            Assert.AreEqual(expected, searchParameter.ReturnAsSQLParameter);
        }

        [TestCase("\"Test String\"")]
        [TestCase("\"Another String\"")]
        public void TestRemoveQuotes(string testString)
        {
            string removedQuotes = new string(testString).Replace("\"", "");
            expected = $@"LIKE '%{removedQuotes}%'";

            searchParameter = new TextParamInclude(testString);
            Assert.AreEqual(expected, searchParameter.ReturnAsSQLParameter);
        }

        [TestCase("TestString      ")]
        [TestCase("        AnotherString    ")]
        public void TestTrim(string testString)
        {
            string trimmedString = new string(testString).Trim();
            expected = $@"LIKE '%{trimmedString}%'";

            searchParameter = new TextParamInclude(testString);
            Assert.AreEqual(expected, searchParameter.ReturnAsSQLParameter);
        }
    }
}
