using NUnit.Framework;
using NewMovieDatabase.SQLBuilder;

namespace TestProject
{
    [TestFixture]
    public class TextParamTests
    {
        string expected;
        ISQLCommandBuilder searchParameter;

        [TestCase("TestString")]
        [TestCase("AnotherString")]
        public void TestTextParamExact(string testString)
        {
            expected = $"LIKE '{testString}'";

            searchParameter = new TextSearchParameter(testString);
            searchParameter = new TextWrapDecorator(searchParameter);
            searchParameter = new LikeDecorator(searchParameter);

            Assert.AreEqual(expected, searchParameter.ToSQLString);
        }

        [TestCase("TestString")]
        [TestCase("AnotherString")]
        public void TestTextParamInclude(string testString)
        {
            expected = $@"LIKE '%{testString}%'";

            searchParameter = new TextSearchParameter(testString);
            searchParameter = new WildCardWrapDecorator(searchParameter);
            searchParameter = new TextWrapDecorator(searchParameter);
            searchParameter = new LikeDecorator(searchParameter);

            Assert.AreEqual(expected, searchParameter.ToSQLString);
        }

        [TestCase("Test'Strin'g")]
        [TestCase("A'notherStrin'g")]
        public void TestRemoveQuotes(string testString)
        {
            string escapedString = new string(testString).Replace("'", "''");
            expected = $"{escapedString}";

            searchParameter = new TextSearchParameter(testString);

            Assert.AreEqual(expected, searchParameter.ToSQLString);
        }

        [TestCase("\"Test String\"")]
        [TestCase("\"Another String\"")]
        public void TestRemoveSlash(string testString)
        {
            string escapedString = new string(testString).Replace("\"", "");
            expected = $"{escapedString}";

            searchParameter = new TextSearchParameter(testString);


            Assert.AreEqual(expected, searchParameter.ToSQLString);
        }

        [TestCase("TestString      ")]
        [TestCase("        AnotherString    ")]
        public void TestTrim(string testString)
        {
            string trimmedString = new string(testString).Trim();
            expected = $"{trimmedString}";

            searchParameter = new TextSearchParameter(testString);

            Assert.AreEqual(expected, searchParameter.ToSQLString);
        }
    }
}
