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

            searchParameter = new TextSearchParameter(testString);
            searchParameter = new ExactLikeDecorator(searchParameter);

            Assert.AreEqual(expected, searchParameter.AsSQLString);
        }

        [TestCase("TestString")]
        [TestCase("AnotherString")]
        public void TestTextParamInclude(string testString)
        {
            expected = $@"LIKE '%{testString}%'";

            searchParameter = new TextSearchParameter(testString);
            searchParameter = new LikeDecorator(searchParameter);

            Assert.AreEqual(expected, searchParameter.AsSQLString);
        }

        [TestCase("Test'Strin'g")]
        [TestCase("A'notherStrin'g")]
        public void TestRemoveQuotes(string testString)
        {
            string escapedString = new string(testString).Replace("'", "''");
            expected = $"{escapedString}";

            searchParameter = new TextSearchParameter(testString);

            Assert.AreEqual(expected, searchParameter.AsSQLString);
        }

        [TestCase("\"Test String\"")]
        [TestCase("\"Another String\"")]
        public void TestRemoveSlash(string testString)
        {
            string escapedString = new string(testString).Replace("\"", "");
            expected = $"{escapedString}";

            searchParameter = new TextSearchParameter(testString);


            Assert.AreEqual(expected, searchParameter.AsSQLString);
        }

        [TestCase("TestString      ")]
        [TestCase("        AnotherString    ")]
        public void TestTrim(string testString)
        {
            string trimmedString = new string(testString).Trim();
            expected = $"{trimmedString}";

            searchParameter = new TextSearchParameter(testString);

            Assert.AreEqual(expected, searchParameter.AsSQLString);
        }
    }
}
