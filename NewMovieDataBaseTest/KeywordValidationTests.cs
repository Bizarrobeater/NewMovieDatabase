using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewMovieDatabase.Keywords;

namespace NewMovieDataBaseTest
{
    [TestClass]
    public class KeywordValidationTests
    {

        [TestMethod]
        public void RegexTests()
        {
            // true names
            string true1 = "name";
            string true2 = "a";
            string true3 = "abcdefghijklmno";
            string true4 = "ABASAS";

            // fail names
            string false1 = "";
            string false2 = "as as";
            string false3 = "1asdb";
            string false4 = "sdfs!!";
            string false5 = "abcdefghijklmnopq";

            KeywordNameValidation test = new KeywordNameValidation();

            Assert.IsTrue(test.VerifyKeywordName(true1));
            Assert.IsTrue(test.VerifyKeywordName(true2));
            Assert.IsTrue(test.VerifyKeywordName(true3));
            Assert.IsTrue(test.VerifyKeywordName(true4));

            Assert.IsFalse(test.VerifyKeywordName(false1));
            Assert.IsFalse(test.VerifyKeywordName(false2));
            Assert.IsFalse(test.VerifyKeywordName(false3));
            Assert.IsFalse(test.VerifyKeywordName(false4));
            Assert.IsFalse(test.VerifyKeywordName(false5));

        }
    }
}
