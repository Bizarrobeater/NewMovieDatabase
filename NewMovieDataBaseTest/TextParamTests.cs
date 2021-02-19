using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewMovieDatabase.SearchParameters;

namespace NewMovieDataBaseTest
{
    [TestClass]
    public class TextParamTests
    {
        [TestMethod]
        public void TestTextParamExact()
        {
            string testString = "Exact";
            string expected = "LIKE 'Exact'";

            ISearchParameter search = new TextParamExact(testString);
            Assert.AreEqual(expected, search.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestTextParamExclude()
        {
            string testString = "Exclude";
            string expected = @"NOT LIKE '%Exclude%'";

            ISearchParameter search = new TextParamExclude(testString);
            Assert.AreEqual(expected, search.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestTextParamInclude()
        {
            string testString = "Include";
            string expected = @"LIKE '%Include%'";

            ISearchParameter search = new TextParamInclude(testString);
            Assert.AreEqual(expected, search.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestEscapeCharacters()
        {
            string testString = "Es'cap'e";
            string expected = @"LIKE '%Es''cap''e%'";

            ISearchParameter search = new TextParamInclude(testString);
            Assert.AreEqual(expected, search.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestRemoveQuotes()
        {
            string testString = "\"Quotes Test\"";
            string expected = @"LIKE '%Quotes Test%'";

            ISearchParameter search = new TextParamInclude(testString);
            Assert.AreEqual(expected, search.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestTrim()
        {
            string testString = " Trimtest   ";
            string expected = @"LIKE '%Trimtest%'";

            ISearchParameter search = new TextParamInclude(testString);
            Assert.AreEqual(expected, search.ReturnAsSQLParameter);
        }
    }
}
